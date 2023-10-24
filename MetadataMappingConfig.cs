using Mapster;

namespace EH.Shared.SdocToXpmConverter.Mapping.Configs
{
    public class MetadataMappingConfig : IRegister
    {
        public void Register( TypeAdapterConfig config )
        {
            // Mapping config for EH.Models.Xpm.Metadata and dependents.
            TypeAdapterConfig<SdocAdapter.Root, Models.Xpm.Metadata>.ForType()
                .Map( dest => dest.EPin, src => src.Adapt<Models.Xpm.EPin>() )
                .IgnoreNonMapped( true );

            TypeAdapterConfig<SdocAdapter.Root, Models.Xpm.EPin>.ForType()
                .Map( dest => dest.EncounterId, src => string.Empty )
                .IgnoreNonMapped( true );
        }
    }
}
