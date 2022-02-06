
Phone phone = new Phone("89290880518");

Console.WriteLine(phone.sumOfNumberInts());
public class Phone{
    string phoneNumber {get; set;}

    public Phone(string phoneNumber){
        this.phoneNumber = phoneNumber;
    }

    public string getPhoneNumber(){
        return phoneNumber;
    }

    public void setPhoneNumber(string number){
        phoneNumber = number;
    }

    public string callSomebody(string firstPerson, string secondPerson){
        return $"{firstPerson} called {secondPerson}, with {this.phoneNumber}";
    }

    public int sumOfNumberInts(){
        int sum = 0;
        for(int i = 0; i<this.phoneNumber.Length; i++){
            sum += (int)Char.GetNumericValue(phoneNumber[i]);
        }

        return sum;
    }
}