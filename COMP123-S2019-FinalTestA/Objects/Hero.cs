using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using COMP123_S2019_FinalTestA.Views;
/*
 * 
 * STUDNET NAME: Jason Li
 * STUDENT ID: 301012468
 * DESCRIPTION : This is the Hero Data Contrainer Class 
 */
namespace COMP123_S2019_FinalTestA.Objects
{
    public class Hero
    {
        // PRIVATE INSTANCE VARIABLES
        private string m_figthing;
        private string m_strength;
        private string m_agility;
        private string m_endurance;

        private string m_reason;
        private string m_intuition;
        private string m_psyche;
        private string m_popularity;

        //Identity
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Physical Abilities
        public string Fighting
        {
            get
            {
                return m_figthing;
            }
            set
            {
                this.m_figthing = value;
                Health += int.Parse(m_figthing);
            }
        }
        public string Strength
        {
            get
            {
                return m_strength;
            }
            set
            {
                this.m_strength = value;
                Health += int.Parse(m_strength);
            }
        }
        public string Agility
        {
            get
            {
                return m_agility;
            }
            set
            {
                this.m_agility = value;
                Health += int.Parse(m_agility);
            }
        }
        public string Endurance
        {
            get
            {
                return m_endurance;
            }
            set
            {
                this.m_endurance = value;
                Health += int.Parse(m_endurance);
            }
        }

        // Mental Abilities
        public string Reason
        {
            get
            {
                return m_reason;
            }
            set
            {
                this.m_reason = value;
                Krama += int.Parse(m_reason);
            }
        }
        public string Intuition
        {
            get
            {
                return m_intuition;
            }
            set
            {
                this.m_intuition = value;
                Krama += int.Parse(m_intuition);
            }
        }
        public string Psyche
        {
            get
            {
                return m_psyche;
            }
            set
            {
                this.m_psyche = value;
                Krama += int.Parse(m_psyche);
            }
        }
        public string Popularity
        {
            get
            {
                return m_popularity;
            }
            set
            {
                this.m_popularity = value;
                Krama += int.Parse(m_popularity);
            }
        }
        //SECONDARY ABILITES
        public int Health { get; set; }
        public int Krama { get; set; }
        //Power List
       public  List<Power> Powers;


        //Consutructor 
        public Hero()
        {
            Powers = new List<Power>();
            
        }
    }
}
