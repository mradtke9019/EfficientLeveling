using Newtonsoft.Json;
using System.IO;

public class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int MajorSkillIncreases { get; set; }
    public int MinorSkillIncreases { get; set; }
    public bool CanLevelUp { get; set; }
    public Attribute[] Attributes { get; set; }
}

public class Attribute
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int SkillIncreases { get; set; }
    public int ExpectedIncrease { get; set; }
    public Skill[] Skills { get; set; }
}

public class Skill
{
    public string Name { get; set; }
    public int Level { get; set; }
    public bool IsMajor { get; set; }
    public int IncreasesThisLevel { get; set; }
}
