using Microsoft.AspNetCore.Mvc;
using PommermanAgentDotNet.ModelBinders;

namespace PommermanAgentDotNet.Models
{
    public class ActionRequestPayload
    {
        [ModelBinder(BinderType = typeof(ObservationEntityBinder))]
        public Observation? Obs { get; set; }

        public string? Action_space { get; set; }
    }
}
