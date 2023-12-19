using EH.Shared.SdocToXpmConverter.Mapping.Tools;
using Mapster;

namespace EH.Shared.SdocToXpmConverter.Mapping.Configs
{
    public class OrderMappingConfig : IRegister
    {
        public void Register( TypeAdapterConfig config )
        {
            // Mapping config for Models.Xpm.Order and dependents.
            TypeAdapterConfig<SdocAdapter.Root, Models.Xpm.Order>.ForType()
                .Map( dest => dest.Appointments, src => new List<Models.Xpm.Appointment>() )
                .Map( dest => dest.Billing, src => new Models.Xpm.Billing() )
                .Map( dest => dest.ClinicalTrials, src => new List<Models.Xpm.ClinicalTrial>() )
                .Map( dest => dest.Contact, src => new Models.Xpm.Contact() )
                .Map( dest => dest.Diagnosis, src => src.PatientVisit.Adapt<Models.Xpm.Diagnosis>() )
                .Map( dest => dest.DietTrayInstructions, src => new Models.Xpm.DietTrayInstructions() )
                .Map( dest => dest.DietaryOrders, src => new Models.Xpm.DietaryOrders() )
                .Map( dest => dest.FinancialTransactions, src => new List<Models.Xpm.FinancialTransactions>() )
                .Map( dest => dest.Generals, src => new List<Models.Xpm.General>() )
                .Map( dest => dest.Locations, src => new List<Models.Xpm.Location>() )
                .Map( dest => dest.Notes, src =>  MappingHelpers.MapNotes( src.Orders ) )
                .Map( dest => dest.Observations, src => MappingHelpers.MapObservations( src.Orders ) )
                .Map( dest => dest.Personnel, src => new List<Models.Xpm.Personnel>() )
                .Map( dest => dest.Procedures, src => MappingHelpers.MapProcedures(src.Orders))
                .Map( dest => dest.Requests, src => new List<Models.Xpm.Request>() )
                .Map( dest => dest.Requisition, src => new Models.Xpm.Requisition() )
                .Map( dest => dest.Resources, src => new List<Models.Xpm.Resource>() )
                .Map( dest => dest.Scheduling, src => new Models.Xpm.Scheduling() )
                .Map( dest => dest.Timings, src => new List<Models.Xpm.Timing>() )
                .IgnoreNonMapped( true );

            TypeAdapterConfig<SdocAdapter.Note, Models.Xpm.Note>.ForType()
                .Map( dest => dest.Comment, src => src.NoteText )
                .Map( dest => dest.SourceOfComment, src => src.Source )
                .IgnoreNonMapped( true );

            TypeAdapterConfig<(SdocAdapter.Procedure Procedure, SdocAdapter.Request Request), Models.Xpm.Procedure>.ForType()
                .Map(dest => dest.Charge, src => src.Procedure.Charge)
                .Map(dest => dest.CPT, src => src.Procedure.CPT)
                .Map(dest => dest.CPTVersionTypesVersion, src => src.Procedure.CPTVersionTypesVersion)
                .Map(dest => dest.ProcedureDescription, src => src.Procedure.ProcedureDescription)
                .Map(dest => dest.ProcedureDescription, src => src.Procedure.ProcedureDescription)


                .Map(dest => dest.ReferringLocationNPI, src => src.Procedure.ReferringLocationNPI)
                .Map(dest => dest.ReferringLocationName, src => src.Procedure.ProcedureDescription)
                .Map(dest => dest.ServicingLocationName, src => src.Procedure.ProcedureDescription)
                .Map(dest => dest.ServicingLocationNPI, src => src.Procedure.ProcedureDescription)
                .Map(dest => dest.ProcedureServiceType, src => src.Procedure.ProcedureDescription)

                .IgnoreNonMapped(true);

            TypeAdapterConfig<SdocAdapter.Diagnose, Models.Xpm.Diagnosis>.ForType()
                .Map(dest => dest.DiagnosisCodeIdentifier, src => src.DiagnosisCodes)

                .IgnoreNonMapped(true);

            TypeAdapterConfig<SdocAdapter.Observation, Models.Xpm.Observation>.ForType()
                .Map( dest => dest.Code, src => src.Code )
                .Map( dest => dest.Description, src => src.Description )
                .Map( dest => dest.InterpretationCode, src => src.InterpretationCode )
                .Map( dest => dest.Method, src => src.Method )
                .Map( dest => dest.ReferenceRange, src => src.ReferenceRange )
                .Map( dest => dest.Status, src => src.Status )
                .Map( dest => dest.SubCode, src => src.SubCode )
                .Map( dest => dest.Type, src => src.Type )
                .Map( dest => dest.Units, src => src.Units )
                .Map( dest => dest.Value, src => src.Value )
                .IgnoreNonMapped( true );
        }
    }
}



        config.ForType<Encounters, SdocRoot>()
             .Map(dest => dest.Orders.FirstOrDefault().Notes.FirstOrDefault().NoteText, src => src.Order.FirstOrDefault().Note.FirstOrDefault().Comment)
             .Map(dest => dest.Orders.FirstOrDefault().Notes.FirstOrDefault().Source, src => src.Order.FirstOrDefault().Note.FirstOrDefault().SourceofComment)
            // .Map(dest => dest.Source, src => src.Order.Note.FirstOrDefault()?.SourceofComment)
             .IgnoreNonMapped(true);
