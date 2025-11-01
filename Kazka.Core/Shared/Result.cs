namespace Domain.Shared
{
    public class Result<ResultObject>
    {
        public bool IsSuccess { get; private set; }
        public ResultObject Ok(ResultObject resultObject) {
            IsSuccess = true;
            return resultObject;
        }
        public void Error()
        {
            IsSuccess = false;
        }
    }
}
