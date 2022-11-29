namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }
        public string ShininessDescription
        {
            get
            {
                if (ShininessLevel > 9)
                {
                    return "Blinding";
                }
                else if (ShininessLevel >= 6)
                {
                    return "Bright";
                }
                else if (ShininessLevel >= 2)
                {
                    return "Noticeable";
                }
                else
                {
                    return "Dull";
                }
            }
        }

    }


}