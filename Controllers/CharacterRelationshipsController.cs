using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KingdomOfRelationships.Models;
using Microsoft.EntityFrameworkCore;

namespace KingdomOfRelationships.Controllers
{
    public class CharacterRelationshipsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var context = new TempRepoContext())
            {
                var model = await context.CharacterRelationship
                .Include(CharacterRelationships => CharacterRelationships.ParentCharacter)
                .Include(CharacterRelationships => CharacterRelationships.ChildCharacter)
                .Include(CharacterRelationships => CharacterRelationships.Relationship)
                .AsNoTracking()
                .ToListAsync();
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            using(var context = new TempRepoContext())
            {
                var vm = new CharacterRelationshipsViewModel();
                vm.Characters = context.Characters.AsNoTracking().ToList();
                vm.Relationships = context.Relationships.AsNoTracking().ToList();
                return View(vm);
            }
        }
    }
}