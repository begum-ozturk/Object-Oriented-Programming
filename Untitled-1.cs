interface ITrainer{
    private addTrainingProgram(member: Member, program: TrainingProgram);
    private trackHealthandSportsInfo(member : Member);
}

class Trainer:ITrainer{
    private int staffID;
    private string name;
    private List<string> specialities;

    public LogIn();
    public LogOut();
}
class TrainingProgram:Trainer{
    private int programID;
    private string programName;
    private List<string> contents;
    private int duration;

    private AddContents(contents:List<string>);
    private RemoveContents(contents : List<string>);
    public getTrainingProgram();
}

interface IDietician{
    private addNutritionProgram(member: Member, program: NutritionProgram);
    private trackHealthandSportsInfo(member : Member);
    public getReport();
}

class Dietician:IDietician{
    private int staffID;
    private string name;
    private List<string> specialities;

    public LogIn();
    public LogOut();
}
class NutritionProgram:Dietician{
    private int programID;
    private string programNAme;
    private List<string> foods;
    private List<string> supplements;

    private AddFoods(foods : List<string>);
    private RemoveFoods(foods : List<string>);
    private AddSupplement(supplements : List<string>);
    private RemoveSupplement(supplements : List<string>);
    public getNutritionProgram();

}

interface IManager{
    private defineMembershipPackages(packet: Packet);
    private defineSalon(salon: Salon);
    private defineSession(session : Session);
    private addVitaminBarProduct(product : VitaminBarProduct);
    private sendSMS(message : string);
    private addTrainer(trainer : Trainer);
    private addDietician(dietician : Dietician);

}
class Manager:IManager{
    private int managerID;
    private string username;
    private int password;
}

class VitaminBarProduct:Manager{
    private int productID;
    private string productName;
    private double price;
    private updatePrice(price: double)
    public getVitaminBar()
}

class Salon:Manager {
    private int salonID;
    private string salonName;
    private int capacity;
    private updateCapacity(capacity: int);
    public getSalonInfo();
}

class Packet:Manager {
    private int packetID;
    private string packetName;
    private int duration;
    private double price;
    private List<string> features;
    private AddFeature(features : string);
    private RemoveFeature(features : string);
    public getPacketInfo();
}

class Session:Manager{

    private int sessionID;
    private Time startTime;
    private Time endTime;
    private UpdateSessionTime(startTime:Time, endTimeÇ Time);
    public getSessionInfo()
}

interface IMember{
    private viewNutritionProgram(member : Member);
    private viewTrainingProgram(member : Member);
    private buyPacket(packet : List<Packet>);
    public getReport();
}
class Member:IMember{
    private int memberID;
    private Date membershipStartDate;
    private Date membershipEndDate; 
    private int wristbandID;
    public getMemberInfo();
}







