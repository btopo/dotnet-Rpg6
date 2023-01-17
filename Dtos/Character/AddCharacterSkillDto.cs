using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_Rpg6.Dtos.Character
{
    public class AddCharacterSkillDto
    {
        public int CharacerId { get; set; }
        public int SkillId { get; set; }
    }
}