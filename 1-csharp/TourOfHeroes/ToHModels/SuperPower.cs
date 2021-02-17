using System;
namespace ToHModels
{
    public class SuperPower
    {
        public int Damage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString() => $"Hero Details: \n\t Name: {this.Name} \n\t SuperPower: {this.Damage} \n\t Type: {this.Description}";
    }
}