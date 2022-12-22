namespace EmployeeManagementSystem.ViewModel
{
    public class ErrorResponseModel
    {
         //custom Exception Middleware
        public string Type { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public ErrorResponseModel(Exception ex)
        {
            Type = ex.GetType().Name;
            Message = ex.Message;
            StackTrace = ex.ToString();
        }
    }
}