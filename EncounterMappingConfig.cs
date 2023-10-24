using Mapster;

namespace EH.Shared.SdocToXpmConverter.Mapping.Configs
{
    public class EncounterMappingConfig : IRegister
    {
        public void Register( TypeAdapterConfig config )
        {
            // Mapping config for EH.Models.Xpm.Encounter and dependents.
            TypeAdapterConfig<SdocAdapter.Root, Models.Xpm.Encounter>.ForType()
                .Map(dest => dest.EncounterId, src => src.PatientVisit.PatientEncounterID)
                .Map(dest => dest.Event, src => src.Adapt<Models.Xpm.Event>())
                .Map(dest => dest.Metadata, src => src.Adapt<Models.Xpm.Metadata>())
                //.Map(dest => dest.Order, src => src.Adapt<Models.Xpm.Order>())
                .Map(dest => dest.Order, src => src.Order)
                .Map(dest => dest.PatientVisit, src => src.Adapt<Models.Xpm.PatientVisit>())
                .Map(dest => dest.Person, src => src.Adapt<Models.Xpm.Person>())
                .Map(dest => dest.OrderManagers, src => src.OrderManagers)
                .Map(dest => dest.ReceivedTimestamp, src => string.Empty)
                .IgnoreNonMapped( true );
        }
    }
}
