namespace helperClass
{
    public class ISBN10 : RulesEngine
    {
        private readonly int[] isbnTenArray = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        public ISBN10(string isbnString, int isbnType) :
        base(isbnString,isbnType)
        {
            this.convertToIntArray();
        }

        public int GetArraySum()
        {
            var result = 0;
            for (int i = 0; i < this.isbnArray.Length; i++)
            {
                result += this.isbnArray[i] * this.isbnTenArray[i];
            }
               Console.WriteLine(result);
            return result;
        }
        public string IsISBNtenValid()
        {
            int arrSum = this.GetArraySum();
            if (arrSum % 11 == 0)
            {
                var isbn13 = $"{this.isbnConst}{this.isbnNumber}";
                ISBN13 newISBN = new ISBN13(isbn13,isbn13.Length);
                if (newISBN.isISBNThirteenValid() == "Invalid"){
                    var remainder = newISBN.GetArraySum() % 10;
                    var lastDigit = (10 - remainder) + newISBN.isbnArray.Last();
                    if (lastDigit == 10){
                        lastDigit = newISBN.isbnArray.Last() - (10 - remainder);
                        newISBN.isbnArray[12] = lastDigit;
                        return newISBN.convertIntArrayToString(); 
                    }
                    else {
                        newISBN.isbnArray[12] = lastDigit;
                        return newISBN.convertIntArrayToString(); 
                    }
                }
            }
            return "Invalid";
        }
    }
}