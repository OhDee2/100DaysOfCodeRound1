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
    public class CharacterController : Controller
    {
        public ActionResult Index(int id = 1)
        {
            using (var context = new TempRepoContext())
            {
                var vm = new CharacterViewModel();
                vm.Character = context.Characters.FirstOrDefault(x => x.CharacterId == id);
                vm.RelatedCharacters = context.CharacterRelationship
                                    .Where(x => x.ParentCharacter.CharacterId == id)
                                    .Select(x => new Character()
                                    {
                                        CharacterId = x.ChildCharacter.CharacterId,
                                        Name = x.ChildCharacter.Name
                                    }).ToList();
                return View(vm);
            }
        }
    }
}