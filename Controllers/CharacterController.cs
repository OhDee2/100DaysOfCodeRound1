using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KingdomOfRelationships.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using KingdomOfRelationships.Helpers;

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
                // Get parents
                vm.RelatedCharacters = context.CharacterRelationship
                                    .Where(x => x.ParentCharacter.CharacterId == id)
                                    .Select(x => new Character()
                                    {
                                        CharacterId = x.ChildCharacter.CharacterId,
                                        Name = x.ChildCharacter.Name
                                    }).ToList();
                // Get children
                vm.RelatedCharacters.AddRange(context.CharacterRelationship
                                    .Where(x => x.ChildCharacter.CharacterId == id)
                                    .Select(x => new Character()
                                    {
                                        CharacterId = x.ParentCharacter.CharacterId,
                                        Name = x.ParentCharacter.Name
                                    }).ToList());
                // strip duplicates
                vm.RelatedCharacters = vm.RelatedCharacters.Distinct(new DistinctCharacterComparer()).ToList();
                return View(vm);
            }
        }
    }
}