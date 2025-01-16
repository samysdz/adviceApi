using Domain.Interfaces;

namespace Application
{
    public class GetAdviceUseCase
    {
        private readonly IAdviceService _adviceService;

        public GetAdviceUseCase(IAdviceService adviceService)
        {
            _adviceService = adviceService;
        }

        public async Task<string> ExecuteAsync()
        {
            var advice = await _adviceService.GetRandomAdviceAsync();
            return advice.Text;
        }
    }
}
