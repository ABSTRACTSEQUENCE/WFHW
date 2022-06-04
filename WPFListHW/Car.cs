namespace WPFListHW
{
    public class Car
    {
        public string name { get; set; }
        public double eng_power { get; set; } //engine power
        public int max_speed { get; set; }

        public Car(string name, double eng_power, int max_speed)
        {
            this.name = name;
            this.eng_power = eng_power;
            this.max_speed = max_speed;
        }
        public Car() { }
    }
}
