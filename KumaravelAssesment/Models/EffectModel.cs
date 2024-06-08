namespace KumaravelAssesment.Models
{
    public class EffectModel
    {
        public int Size { get; set; }
        public int Radius { get; set; }              
        //Here i given diction to add any effects with key and value.like property name and its value
        public Dictionary<string,int> Effects { get; set; }
    }
}
