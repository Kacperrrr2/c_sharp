using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalQuestionnaireWpfApp.Models
{
    public struct PersonalDataModel
    {
        public string name;
        public bool isPizzaWithPineapple;
        public bool isMale;
        public bool isFemale;
        public List<string> listOfDish = new List<string>();
        public string selectedDish;



        public PersonalDataModel()
        {
            name = "";
            isPizzaWithPineapple = false;
            isMale = false;
            isFemale = false;
            listOfDish = new List<string>()
            {
                "mielony","kula mocy"
            };
            selectedDish = listOfDish.First();
        }
    }
}
