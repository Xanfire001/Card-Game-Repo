using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Card_Game.BLL
{
    //public enum IEffekte
    //{
    //    Axtwurf,
    //    Schildblock,
    //    Pfeilregen,
    //    Kavallerie_rufen,
    //    Valküre
    //}
    public class Card
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public ICollection<IEffekte> Karteneffekt { get; set; }


    }
}
