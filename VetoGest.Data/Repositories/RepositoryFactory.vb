Imports VetoGest.Data.Repositories

Public Module RepositoryFactory


    Public ReadOnly Property GetAgentRepository As AgentRepository
        Get
            Return New AgentRepository()
        End Get
    End Property


    Public ReadOnly Property GetClientRepository As ClientRepository
        Get
            Return New ClientRepository()
        End Get
    End Property

    Public ReadOnly Property GetEspeceRepository As EspeceRepository
        Get
            Return New EspeceRepository()
        End Get
    End Property

    Public ReadOnly Property GetAnimalRepository As AnimalRepository
        Get
            Return New AnimalRepository()
        End Get
    End Property

End Module
