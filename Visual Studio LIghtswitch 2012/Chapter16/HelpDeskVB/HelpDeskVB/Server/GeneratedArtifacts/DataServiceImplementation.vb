﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Namespace LightSwitchApplication.Implementation
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class ApplicationDataDataService
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.DataService(Of Global.ApplicationData.Implementation.ApplicationDataObjectContext)
    
        Public Sub New()
            MyBase.New()
        End Sub
    
        Protected Overrides Function CreateDataService() As Global.Microsoft.LightSwitch.IDataService
            Return New Global.LightSwitchApplication.DataWorkspace().ApplicationData
        End Function
    
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class ApplicationDataServiceImplementation
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation(Of Global.ApplicationData.Implementation.ApplicationDataObjectContext)
    
        Public Sub New(ByVal dataService As Global.Microsoft.LightSwitch.IDataService)
            MyBase.New(dataService)
        End Sub
    
    #Region "Queries"
    #End Region

    #Region "Protected methods"
        Protected Overrides Function CreateObject(ByVal type As Global.System.Type) As Object
            If (type Is GetType(Global.ApplicationData.Implementation.Engineer)) Then
                Return New Global.ApplicationData.Implementation.Engineer
            End If
            If (type Is GetType(Global.ApplicationData.Implementation.Issue)) Then
                Return New Global.ApplicationData.Implementation.Issue
            End If
            If (type Is GetType(Global.ApplicationData.Implementation.IssueStatus)) Then
                Return New Global.ApplicationData.Implementation.IssueStatus
            End If
            If (type Is GetType(Global.ApplicationData.Implementation.Skill)) Then
                Return New Global.ApplicationData.Implementation.Skill
            End If
            If (type Is GetType(Global.ApplicationData.Implementation.EngineerSkill)) Then
                Return New Global.ApplicationData.Implementation.EngineerSkill
            End If
            If (type Is GetType(Global.ApplicationData.Implementation.TimeTracking)) Then
                Return New Global.ApplicationData.Implementation.TimeTracking
            End If
    
            Return MyBase.CreateObject(type)
        End Function
    
        Protected Overrides Function CreateObjectContext() As Global.ApplicationData.Implementation.ApplicationDataObjectContext
            Dim assemblyName As String = Global.System.Reflection.Assembly.GetExecutingAssembly().GetName().Name
            Return New Global.ApplicationData.Implementation.ApplicationDataObjectContext(MyBase.GetEntityConnectionString( _
                "_IntrinsicData", _
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl", _
                "System.Data.SqlClient"))
        End Function
    
        Protected Overrides Function CreateEntityImplementation(Of T As Global.Microsoft.LightSwitch.IEntityObject)() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.Engineer)) Then
                Return New Global.ApplicationData.Implementation.Engineer()
            End If
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.Issue)) Then
                Return New Global.ApplicationData.Implementation.Issue()
            End If
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.IssueStatus)) Then
                Return New Global.ApplicationData.Implementation.IssueStatus()
            End If
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.Skill)) Then
                Return New Global.ApplicationData.Implementation.Skill()
            End If
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.EngineerSkill)) Then
                Return New Global.ApplicationData.Implementation.EngineerSkill()
            End If
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.TimeTracking)) Then
                Return New Global.ApplicationData.Implementation.TimeTracking()
            End If
            Return Nothing
        End Function
    
    #End Region
    
    End Class
    
    
    #Region "DataServiceImplementationFactory"
    <Global.System.ComponentModel.Composition.PartCreationPolicy(Global.System.ComponentModel.Composition.CreationPolicy.Shared)> _
    <Global.System.ComponentModel.Composition.Export(GetType(Global.Microsoft.LightSwitch.Internal.IDataServiceFactory))> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class DataServiceFactory
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    
        Protected Overrides Function CreateDataService(ByVal dataServiceType As Global.System.Type) As Global.Microsoft.LightSwitch.IDataService
            If dataServiceType.Equals(GetType(Global.LightSwitchApplication.ApplicationData)) Then
                Return New Global.LightSwitchApplication.ApplicationDataService()
            End If
            Return MyBase.CreateDataService(dataServiceType)
        End Function
    
        Protected Overrides Function CreateDataServiceImplementation(Of TDataService As Global.Microsoft.LightSwitch.IDataService)(ByVal dataService As TDataService) As Global.Microsoft.LightSwitch.Internal.IDataServiceImplementation
            If GetType(TDataService).Equals(GetType(Global.LightSwitchApplication.ApplicationData)) Then
                Return New Global.LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService)
            End If
            Return MyBase.CreateDataServiceImplementation(dataService)
        End Function
    End Class
    #End Region
    
    <Global.System.ComponentModel.Composition.PartCreationPolicy(Global.System.ComponentModel.Composition.CreationPolicy.Shared)> _
    <Global.System.ComponentModel.Composition.Export(GetType(Global.Microsoft.LightSwitch.Internal.ITypeMappingProvider))> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class __TypeMapping
        Implements Global.Microsoft.LightSwitch.Internal.ITypeMappingProvider
        Private Function GetImplementationType(ByVal definitionType As Global.System.Type) As Global.System.Type Implements Global.Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType
            If GetType(Global.LightSwitchApplication.Engineer).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.Engineer)
            End If
            If GetType(Global.LightSwitchApplication.Issue).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.Issue)
            End If
            If GetType(Global.LightSwitchApplication.IssueStatus).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.IssueStatus)
            End If
            If GetType(Global.LightSwitchApplication.Skill).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.Skill)
            End If
            If GetType(Global.LightSwitchApplication.EngineerSkill).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.EngineerSkill)
            End If
            If GetType(Global.LightSwitchApplication.TimeTracking).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.TimeTracking)
            End If
            Return Nothing
        End Function
    End Class
End Namespace

Namespace ApplicationData.Implementation

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Partial Public Class Engineer
        Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _RowVersionImplementation() As Byte() Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.RowVersion
            Get
                Return Me.RowVersion
            End Get
            Set(ByVal value As Byte())
                Me.RowVersion = value
            End Set
        End Property
        
        Private Property _SurnameImplementation() As String Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.Surname
            Get
                Return Me.Surname
            End Get
            Set(ByVal value As String)
                Me.Surname = value
            End Set
        End Property
        
        Private Property _FirstnameImplementation() As String Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.Firstname
            Get
                Return Me.Firstname
            End Get
            Set(ByVal value As String)
                Me.Firstname = value
            End Set
        End Property
        
        Private Property _DateOfBirthImplementation() As Date Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.DateOfBirth
            Get
                Return Me.DateOfBirth
            End Get
            Set(ByVal value As Date)
                Me.DateOfBirth = value
            End Set
        End Property
        
        Private Property _LoginNameImplementation() As String Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.LoginName
            Get
                Return Me.LoginName
            End Get
            Set(ByVal value As String)
                Me.LoginName = value
            End Set
        End Property
        
        Private Property _SSNImplementation() As String Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.SSN
            Get
                Return Me.SSN
            End Get
            Set(ByVal value As String)
                Me.SSN = value
            End Set
        End Property
        
        Private Property _EngineerPhotoImplementation() As Byte() Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.EngineerPhoto
            Get
                Return Me.EngineerPhoto
            End Get
            Set(ByVal value As Byte())
                Me.EngineerPhoto = value
            End Set
        End Property
        
        Private Property _SecurityVettedImplementation() As Boolean Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.SecurityVetted
            Get
                Return Me.SecurityVetted
            End Get
            Set(ByVal value As Boolean)
                Me.SecurityVetted = value
            End Set
        End Property
        
        Private Property _ClearanceReferenceImplementation() As String Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.ClearanceReference
            Get
                Return Me.ClearanceReference
            End Get
            Set(ByVal value As String)
                Me.ClearanceReference = value
            End Set
        End Property
        
        Private Property _VettingExpiryDateImplementation() As Global.System.Nullable(Of Date) Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.VettingExpiryDate
            Get
                Return Me.VettingExpiryDate
            End Get
            Set(ByVal value As Global.System.Nullable(Of Date))
                Me.VettingExpiryDate = value
            End Set
        End Property
        
        Private Property _EmailAddressImplementation() As String Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.EmailAddress
            Get
                Return Me.EmailAddress
            End Get
            Set(ByVal value As String)
                Me.EmailAddress = value
            End Set
        End Property
        
        Private ReadOnly Property _IssuesImplementation() As Global.System.Collections.IEnumerable Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.Issues
            Get
                Return Me.Issues
            End Get
        End Property
        
        Private ReadOnly Property _EngineerIssuesImplementation() As Global.System.Collections.IEnumerable Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.EngineerIssues
            Get
                Return Me.EngineerIssues
            End Get
        End Property
        
        Private ReadOnly Property _ManagerImplementation() As Global.System.Collections.IEnumerable Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.Manager
            Get
                Return Me.Manager
            End Get
        End Property
        
        Private Property _SubordinatesImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.Subordinates
            Get
                Return Me.Subordinates
            End Get
            Set(ByVal value As Global.Microsoft.LightSwitch.Internal.IEntityImplementation)
                Me.Subordinates = DirectCast(value, Global.ApplicationData.Implementation.Engineer)
                If Me.__host IsNot Nothing Then
                    Me.__host.RaisePropertyChanged("Subordinates")
                End If
            End Set
        End Property
        
        Private ReadOnly Property _EngineerSkillsImplementation() As Global.System.Collections.IEnumerable Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.EngineerSkills
            Get
                Return Me.EngineerSkills
            End Get
        End Property
        
        Private ReadOnly Property _TimeTrackingsImplementation() As Global.System.Collections.IEnumerable Implements Global.LightSwitchApplication.Engineer.DetailsClass.IImplementation.TimeTrackings
            Get
                Return Me.TimeTrackings
            End Get
        End Property
        
        Private Sub OnEngineer_EngineerChanged()
            If Me.__host IsNot Nothing Then
                Me.__host.RaisePropertyChanged("Subordinates")
            End If
        End Sub
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Partial Public Class Issue
        Implements Global.LightSwitchApplication.Issue.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.Issue.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _RowVersionImplementation() As Byte() Implements Global.LightSwitchApplication.Issue.DetailsClass.IImplementation.RowVersion
            Get
                Return Me.RowVersion
            End Get
            Set(ByVal value As Byte())
                Me.RowVersion = value
            End Set
        End Property
        
        Private Property _TargetEndDateTimeImplementation() As Date Implements Global.LightSwitchApplication.Issue.DetailsClass.IImplementation.TargetEndDateTime
            Get
                Return Me.TargetEndDateTime
            End Get
            Set(ByVal value As Date)
                Me.TargetEndDateTime = value
            End Set
        End Property
        
        Private Property _SubjectImplementation() As String Implements Global.LightSwitchApplication.Issue.DetailsClass.IImplementation.Subject
            Get
                Return Me.Subject
            End Get
            Set(ByVal value As String)
                Me.Subject = value
            End Set
        End Property
        
        Private Property _CreateDateTimeImplementation() As Date Implements Global.LightSwitchApplication.Issue.DetailsClass.IImplementation.CreateDateTime
            Get
                Return Me.CreateDateTime
            End Get
            Set(ByVal value As Date)
                Me.CreateDateTime = value
            End Set
        End Property
        
        Private Property _ProblemDescriptionImplementation() As String Implements Global.LightSwitchApplication.Issue.DetailsClass.IImplementation.ProblemDescription
            Get
                Return Me.ProblemDescription
            End Get
            Set(ByVal value As String)
                Me.ProblemDescription = value
            End Set
        End Property
        
        Private Property _AssignedToImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation Implements Global.LightSwitchApplication.Issue.DetailsClass.IImplementation.AssignedTo
            Get
                Return Me.AssignedTo
            End Get
            Set(ByVal value As Global.Microsoft.LightSwitch.Internal.IEntityImplementation)
                Me.AssignedTo = DirectCast(value, Global.ApplicationData.Implementation.Engineer)
                If Me.__host IsNot Nothing Then
                    Me.__host.RaisePropertyChanged("AssignedTo")
                End If
            End Set
        End Property
        
        Private Property _ClosedByEngineerImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation Implements Global.LightSwitchApplication.Issue.DetailsClass.IImplementation.ClosedByEngineer
            Get
                Return Me.ClosedByEngineer
            End Get
            Set(ByVal value As Global.Microsoft.LightSwitch.Internal.IEntityImplementation)
                Me.ClosedByEngineer = DirectCast(value, Global.ApplicationData.Implementation.Engineer)
                If Me.__host IsNot Nothing Then
                    Me.__host.RaisePropertyChanged("ClosedByEngineer")
                End If
            End Set
        End Property
        
        Private ReadOnly Property _TimeTrackingsImplementation() As Global.System.Collections.IEnumerable Implements Global.LightSwitchApplication.Issue.DetailsClass.IImplementation.TimeTrackings
            Get
                Return Me.TimeTrackings
            End Get
        End Property
        
        Private Sub OnIssue_EngineerChanged()
            If Me.__host IsNot Nothing Then
                Me.__host.RaisePropertyChanged("AssignedTo")
            End If
        End Sub
        
        Private Sub OnIssue_Engineer1Changed()
            If Me.__host IsNot Nothing Then
                Me.__host.RaisePropertyChanged("ClosedByEngineer")
            End If
        End Sub
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Partial Public Class IssueStatus
        Implements Global.LightSwitchApplication.IssueStatus.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.IssueStatus.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _RowVersionImplementation() As Byte() Implements Global.LightSwitchApplication.IssueStatus.DetailsClass.IImplementation.RowVersion
            Get
                Return Me.RowVersion
            End Get
            Set(ByVal value As Byte())
                Me.RowVersion = value
            End Set
        End Property
        
        Private Property _StatusDescriptionImplementation() As String Implements Global.LightSwitchApplication.IssueStatus.DetailsClass.IImplementation.StatusDescription
            Get
                Return Me.StatusDescription
            End Get
            Set(ByVal value As String)
                Me.StatusDescription = value
            End Set
        End Property
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Partial Public Class Skill
        Implements Global.LightSwitchApplication.Skill.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.Skill.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _RowVersionImplementation() As Byte() Implements Global.LightSwitchApplication.Skill.DetailsClass.IImplementation.RowVersion
            Get
                Return Me.RowVersion
            End Get
            Set(ByVal value As Byte())
                Me.RowVersion = value
            End Set
        End Property
        
        Private Property _SkillDescriptionImplementation() As String Implements Global.LightSwitchApplication.Skill.DetailsClass.IImplementation.SkillDescription
            Get
                Return Me.SkillDescription
            End Get
            Set(ByVal value As String)
                Me.SkillDescription = value
            End Set
        End Property
        
        Private ReadOnly Property _EngineerSkillsImplementation() As Global.System.Collections.IEnumerable Implements Global.LightSwitchApplication.Skill.DetailsClass.IImplementation.EngineerSkills
            Get
                Return Me.EngineerSkills
            End Get
        End Property
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Partial Public Class EngineerSkill
        Implements Global.LightSwitchApplication.EngineerSkill.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.EngineerSkill.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _RowVersionImplementation() As Byte() Implements Global.LightSwitchApplication.EngineerSkill.DetailsClass.IImplementation.RowVersion
            Get
                Return Me.RowVersion
            End Get
            Set(ByVal value As Byte())
                Me.RowVersion = value
            End Set
        End Property
        
        Private Property _SkillImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation Implements Global.LightSwitchApplication.EngineerSkill.DetailsClass.IImplementation.Skill
            Get
                Return Me.Skill
            End Get
            Set(ByVal value As Global.Microsoft.LightSwitch.Internal.IEntityImplementation)
                Me.Skill = DirectCast(value, Global.ApplicationData.Implementation.Skill)
                If Me.__host IsNot Nothing Then
                    Me.__host.RaisePropertyChanged("Skill")
                End If
            End Set
        End Property
        
        Private Property _EngineerImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation Implements Global.LightSwitchApplication.EngineerSkill.DetailsClass.IImplementation.Engineer
            Get
                Return Me.Engineer
            End Get
            Set(ByVal value As Global.Microsoft.LightSwitch.Internal.IEntityImplementation)
                Me.Engineer = DirectCast(value, Global.ApplicationData.Implementation.Engineer)
                If Me.__host IsNot Nothing Then
                    Me.__host.RaisePropertyChanged("Engineer")
                End If
            End Set
        End Property
        
        Private Sub OnEngineerSkill_SkillChanged()
            If Me.__host IsNot Nothing Then
                Me.__host.RaisePropertyChanged("Skill")
            End If
        End Sub
        
        Private Sub OnEngineerSkill_EngineerChanged()
            If Me.__host IsNot Nothing Then
                Me.__host.RaisePropertyChanged("Engineer")
            End If
        End Sub
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Partial Public Class TimeTracking
        Implements Global.LightSwitchApplication.TimeTracking.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.TimeTracking.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _RowVersionImplementation() As Byte() Implements Global.LightSwitchApplication.TimeTracking.DetailsClass.IImplementation.RowVersion
            Get
                Return Me.RowVersion
            End Get
            Set(ByVal value As Byte())
                Me.RowVersion = value
            End Set
        End Property
        
        Private Property _DurationMinsImplementation() As Integer Implements Global.LightSwitchApplication.TimeTracking.DetailsClass.IImplementation.DurationMins
            Get
                Return Me.DurationMins
            End Get
            Set(ByVal value As Integer)
                Me.DurationMins = value
            End Set
        End Property
        
        Private Property _EngineerImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation Implements Global.LightSwitchApplication.TimeTracking.DetailsClass.IImplementation.Engineer
            Get
                Return Me.Engineer
            End Get
            Set(ByVal value As Global.Microsoft.LightSwitch.Internal.IEntityImplementation)
                Me.Engineer = DirectCast(value, Global.ApplicationData.Implementation.Engineer)
                If Me.__host IsNot Nothing Then
                    Me.__host.RaisePropertyChanged("Engineer")
                End If
            End Set
        End Property
        
        Private Property _IssueImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation Implements Global.LightSwitchApplication.TimeTracking.DetailsClass.IImplementation.Issue
            Get
                Return Me.Issue
            End Get
            Set(ByVal value As Global.Microsoft.LightSwitch.Internal.IEntityImplementation)
                Me.Issue = DirectCast(value, Global.ApplicationData.Implementation.Issue)
                If Me.__host IsNot Nothing Then
                    Me.__host.RaisePropertyChanged("Issue")
                End If
            End Set
        End Property
        
        Private Sub OnTimeTracking_EngineerChanged()
            If Me.__host IsNot Nothing Then
                Me.__host.RaisePropertyChanged("Engineer")
            End If
        End Sub
        
        Private Sub OnTimeTracking_IssueChanged()
            If Me.__host IsNot Nothing Then
                Me.__host.RaisePropertyChanged("Issue")
            End If
        End Sub
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
    End Class
    
End Namespace
