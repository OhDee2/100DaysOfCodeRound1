using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KingdomOfRelationships.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

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
            using (var context = new TempRepoContext())
            {
                var vm = new CharacterRelationshipsViewModel();
                vm.Characters = context.Characters.AsNoTracking().OrderBy(c => c.Name).ToList();
                vm.Relationships = context.Relationships.AsNoTracking().OrderBy(r => r.Description).ToList();
                return View(vm);
            }
        }

        [HttpPost]
        public ActionResult Create(CharacterRelationshipsViewModel viewModel)
        {
            using (var context = new TempRepoContext())
            {
                context.CharacterRelationship.Add(new CharacterRelationships()
                {
                    ChildCharacter = context.Characters.SingleOrDefault(x => x.CharacterId == viewModel.SelectedChildCharacter),
                    ParentCharacter = context.Characters.SingleOrDefault(x => x.CharacterId == viewModel.SelectedParentCharacter),
                    Relationship = context.Relationships.SingleOrDefault(x => x.RelationshipId == viewModel.SelectedRelationship),
                });
                context.SaveChanges();
            }
            return RedirectToAction("Index", viewModel);
        }
    }
}