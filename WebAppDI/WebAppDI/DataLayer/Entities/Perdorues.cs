namespace WebAppDI.DataLayer.Entities
{
    public class Perdorues : BaseEntity
    {
        public string Mbiemri { get; set; }
        public DateTime Ditelindje { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string EmriPlote { get; set; }

        public void VendosEmrinEPlote()
        {
            //Kontrollo Emrin
            if (Emri == null)
            {
                throw new Exception("Emri smund te jete bosh");
            }
            //Kontrollo Mbiemrin
            if (Mbiemri == null)
            {
                throw new Exception("Mbiemri smund te jete bosh");
            }
            EmriPlote = Emri + " " + Mbiemri;
        }

        //Validon Email
        public bool ValidoEmail()
        {
            if(!Email.Contains("@") || !Email.EndsWith(".com"))
            {
                return false;
            }
            return true;
        }

        //Valido Moshen
        public bool ValidoMoshen()
        {
            var mosha = DateTime.Now.Year - Ditelindje.Year;
            if(mosha > 130)
            {
                return false;
            }
            return true;
        }

        //Valido Adresen 
        public bool ValidoAddresen()
        {
            if (Adress.Contains("*") || Adress.Contains("/"))
            {
                return false;
            }
            return true;
        }

    }
}
