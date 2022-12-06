namespace QuanLyHocSinh.Models
{
    public class Response<TResponse>
    {
        public TResponse? Result { get; set; }

        public static Response<TResponse> CreateResponse(TResponse result)
        {
            return new Response<TResponse>
            {
                Result = result,
            };
        }
        private Response() { }
    }

}
