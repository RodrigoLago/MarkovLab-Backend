
using MarkovLab.Domain.Algorithms.Viterbi;
using MarkovLab.Domain.Models;
using MarkovLab.Domain.Validators;
using MarkovLabBackend.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MarkovLabBackend.Api.Controllers
{
    [ApiController]
    [Route("api/hmm")]
    public class HmmController : ControllerBase
    {
        private readonly HiddenMarkovModelValidator _validator;
        private readonly ViterbiAlgorithm _viterbi;

        public HmmController()
        {
            _validator = new HiddenMarkovModelValidator();
            _viterbi = new ViterbiAlgorithm(_validator);
        }

        [HttpPost("viterbi")]
        public IActionResult Viterbi([FromBody] ViterbiRequest request)
        {
            var errors = _validator.Validate(request.Model);

            if (errors.Count > 0)
                return BadRequest(errors);

            var sequence = new DnaSequence(request.Sequence);
            var result = _viterbi.Execute(request.Model, sequence);

            return Ok(result);
        }
    }
}
