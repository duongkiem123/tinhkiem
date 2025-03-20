using System.Collections.Generic;
using UnityEngine;

namespace GameSkills
{
    public class SkillDatabase : MonoBehaviour
    {
        public List<Skill> skills = new List<Skill> {
        new Skill { ItemID = 8489, RequireFaction = 1, RequireLevel = 10, SkillID = 10019, Name = "Đạt Ma Độ Giang" }, // Thiếu Lâm
        new Skill { ItemID = 8497, RequireFaction = 3, RequireLevel = 10, SkillID = 10137, Name = "Bạo Vũ Lê Hoa" }, // Đường Môn
        new Skill { ItemID = 8500, RequireFaction = 5, RequireLevel = 10, SkillID = 10161, Name = "Tam Nga Tề Tuyết" } // Nga My
    };
    }

    [System.Serializable]
    public class Skill
    {
        public int ItemID;
        public int RequireFaction;
        public int RequireLevel;
        public int SkillID;
        public string Name;
    }
}