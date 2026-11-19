using MarkovLab.Domain.Models;

namespace MarkovLabBackend.Api.Dtos
{
    public class ViterbiRequest
    {
        public required HiddenMarkovModel Model { get; init; }
        public required string Sequence { get; init; }
    }
}
