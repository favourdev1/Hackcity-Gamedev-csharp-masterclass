using System;

namespace Phone
{
	public class Program
	{
		public static void Main()
		{
			//to test it 
		GSM Iphone  = new GSM ("Iphone 13", "apple");
			Console.WriteLine(Iphone.ToString());
		}
		
		
		class GSM
	{
		private Battery battery  = new Battery();
		private Display display = new Display();

      
	

		public string model { get; set; }

		public string manufacturer { get; set; }

		public int price { get; set; }

		public string owner { get; set; }

  		// constructor
		public GSM(string model, string manufacturer)
		{
			this.model = model;
			this.manufacturer = manufacturer;
		}

		public GSM(string model, string manufacturer, int price, Battery battery, string owner, Display display)
		{
			this.model = model;
			this.manufacturer = manufacturer;
			this.price = price;
			this.battery = battery;
			this.display = display;
            
		}


	 public Battery GsmBattery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display GsmDisplay
        {
            get { return this.display; }
            set { this.display = value; }
        }





//overiding default tostring method for all objects
        public override string ToString(){
        
		string value = string.Format ("Heres your phone Info \n Model : " + this.model +" \n Manufacturer : "+ this.manufacturer );

        value += this.owner == null ? "\n owner:[no Information ] ": "\n owner: "+this.owner ;
        


		value += this.price <1 ? "\n price : [no info]": "\n price :" + this.price;


		value += this.battery.Model == null ? "\n BatteryModel : [no Info]" : "\n BatteryModel : "+ this . battery.Model;

		value += this.battery.IdleHour == null ? "\n Idle Hour : 0" :"\n Idle Hour :" + this.battery.IdleHour;

		value += this.battery.TalkHour == null ? "\n TalkHours : 0" : "\n TalkHours : "+ this .battery.TalkHour;


		value += this .battery.Type == null ? "\n BatteryType : [no info]" : "\n BatteryType : "+ this . battery.Type;

		value += this .display.Size <1 ? "\n Displaysize : [no info]" : "\n Displaysize : "+ this . display.Size;


		value += this.display.Color<1 ? "\n Displaycolor : [no info]" : "\n Displaycolor : "+ this . display.Color;


		return value;
        }
	}



	// using enumn for battery type

	public enum BatteryType{
		   CalciumaAir ,
		   IronAir ,
		   PotassiumIon ,
		   SiliconAir,
		LiIon
	}

	class Battery
	{

		private BatteryType type;

		public string Model { get; set; }

		public double IdleHour { get; set; }

		public double TalkHour { get; set; }

		 public BatteryType Type
        {
            get { return this.type; }
        }

		    //Constructors
        public Battery()
        {
        }
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.IdleHour = hoursIdle;
            this.TalkHour = hoursTalk;
            this.type = type;
        }

	}

	class Display
	{
		public float Size { get; set; }

		public int Color { get; set; }
		public Display(){
			this.Size =0;
			this.Color =0;
		}
		
		public Display (float size , int color){
			this.Size = size;
			this.Color = color;
		}
	}
	}






	
}
