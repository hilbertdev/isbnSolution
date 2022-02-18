using System.Text;
namespace helperClass
{
    public class RulesEngine
    {
        public readonly string isbnNumber;
        public readonly string isbnConst = "978";

        public int[] isbnArray { get; set; }

        public RulesEngine(string IsbnNumber, int isbnType)
        {
            isbnNumber = IsbnNumber;
            this.IsValidInput = validateString();
            this.isbnArray = new int[isbnType];
        }
        public bool validateString()
        {
                var lastCharacter = this.isbnNumber[this.isbnNumber.Length - 1];
                var newString = this.isbnNumber.Substring(0, this.isbnNumber.Length - 1);
                if (newString.Any(c => char.IsNumber(c) != true))
                {
                    return false;
                }
                if ( char.IsNumber(lastCharacter) != true && lastCharacter != 'X')
                {
                    return false;
                }
                return true;
        }

        public bool IsValidInput { get; set; }
        public void convertToIntArray()
        {
            if (this.IsValidInput)
            {
                for (int i = 0; i < this.isbnArray.Count(); i++)
                {
                    if (this.isbnNumber[i] == 'X')
                    {
                        this.isbnArray[i] = 10;
                    }
                    this.isbnArray[i] = (int)char.GetNumericValue(this.isbnNumber[i]);
                }
            }
        }
        public string convertIntArrayToString(){
           StringBuilder sb = new StringBuilder();
           foreach (int i in this.isbnArray){
               sb.Append(i.ToString());
           }
           return sb.ToString();
        }
    }
}