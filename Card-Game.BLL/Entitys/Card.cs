using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Card_Game.BLL.Entitys
{
    public enum IEffekte
    {
        Axtwurf,
        Schildblock,
        Pfeilregen,
        Kavallerie_rufen,
        Valküre
    }
    public class Card
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<IEffekte> Karteneffekt { get; set; }


    }
}
