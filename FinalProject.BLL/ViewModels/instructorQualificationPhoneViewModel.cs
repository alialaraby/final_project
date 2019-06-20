namespace FinalProject.BLL.ViewModels
{
  public  class instructorQualificationPhoneViewModel
    {
         
        public int instructor_id { get; set; }
        
        public string instructor_name { get; set; }

        public string Current_JobTitle { get; set; }

        public string NameOf_ItsUnit { get; set; }

        public string TrainningTopic { get; set; }

        //custum attribute

        public string qualification_name { get; set; }
        public string phone { get; set; }
    }
}
