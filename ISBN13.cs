namespace helperClass
{
    public class ISBN13 : RulesEngine
    {
        private readonly int[] isbnThirteen = new int[] { 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3,1 };
        public ISBN13(string isbnString, int isbnType) :
        base(isbnString, isbnType)
        {
            this.convertToIntArray();
        }

        public int GetArraySum()
        {
            var result = 0;
            for (int i = 0; i < this.isbnArray.Length; i++)
            {
                result += this.isbnArray[i] * this.isbnThirteen[i];    
            }
            return result;
        }
        public string isISBNThirteenValid()
        {
            int arrSum = this.GetArraySum();
            if (arrSum % 10 == 0)
            {
                return "Valid";
            }
            return "Invalid";
        }
    }
}