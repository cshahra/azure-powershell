---
external help file: Microsoft.Azure.PowerShell.Cmdlets.ResourceManager.dll-Help.xml
Module Name: Az.Resources
online version: https://learn.microsoft.com/powershell/module/az.resources/Test-AzSubscriptionDeploymentStack
schema: 2.0.0
---

# Test-AzSubscriptionDeploymentStack

## SYNOPSIS
Validates a subscription scoped deployment stack.

## SYNTAX

### ByTemplateFileWithNoParameters (Default)
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateFile <String> [-SkipTemplateParameterPrompt] [-QueryString <String>]
 [-Pre] [-DefaultProfile <IAzureContextContainer>] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ByTemplateFileWithParameterFile
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateFile <String> -TemplateParameterFile <String>
 [-SkipTemplateParameterPrompt] [-QueryString <String>] [-Pre] [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByTemplateFileWithParameterUri
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateFile <String> -TemplateParameterUri <String>
 [-SkipTemplateParameterPrompt] [-QueryString <String>] [-Pre] [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByTemplateFileWithParameterObject
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateFile <String> -TemplateParameterObject <Hashtable>
 [-SkipTemplateParameterPrompt] [-QueryString <String>] [-Pre] [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByTemplateUriWithParameterFile
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateUri <String> -TemplateParameterFile <String>
 [-SkipTemplateParameterPrompt] [-QueryString <String>] [-Pre] [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByTemplateUriWithParameterUri
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateUri <String> -TemplateParameterUri <String>
 [-SkipTemplateParameterPrompt] [-QueryString <String>] [-Pre] [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByTemplateUriWithParameterObject
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateUri <String> -TemplateParameterObject <Hashtable>
 [-SkipTemplateParameterPrompt] [-QueryString <String>] [-Pre] [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByTemplateUriWithNoParameters
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateUri <String> [-SkipTemplateParameterPrompt] [-QueryString <String>]
 [-Pre] [-DefaultProfile <IAzureContextContainer>] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ByTemplateSpecWithParameterFile
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateSpecId <String> -TemplateParameterFile <String>
 [-SkipTemplateParameterPrompt] [-QueryString <String>] [-Pre] [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByTemplateSpecWithParameterUri
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateSpecId <String> -TemplateParameterUri <String>
 [-SkipTemplateParameterPrompt] [-QueryString <String>] [-Pre] [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByTemplateSpecWithParameterObject
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateSpecId <String> -TemplateParameterObject <Hashtable>
 [-SkipTemplateParameterPrompt] [-QueryString <String>] [-Pre] [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByTemplateSpecWithNoParameters
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateSpecId <String> [-SkipTemplateParameterPrompt] [-QueryString <String>]
 [-Pre] [-DefaultProfile <IAzureContextContainer>] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ByParameterFileWithNoTemplate
```
Test-AzSubscriptionDeploymentStack [-PassThru] [-Name] <String> [-Description <String>] -Location <String>
 -ActionOnUnmanage <PSActionOnUnmanage> -DenySettingsMode <PSDenySettingsMode>
 [-DenySettingsExcludedPrincipal <String[]>] [-DenySettingsExcludedAction <String[]>]
 [-DenySettingsApplyToChildScopes] [-DeploymentResourceGroupName <String>] [-Tag <Hashtable>] [-Force] [-AsJob]
 [-BypassStackOutOfSyncError] -TemplateParameterFile <String> [-SkipTemplateParameterPrompt]
 [-QueryString <String>] [-Pre] [-DefaultProfile <IAzureContextContainer>] [-ProgressAction <ActionPreference>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Validates a subscription scoped deployment stack.

## EXAMPLES

### Example 1: Create a subscription scoped deployment stack MySubStack at westus location
```powershell
Test-AzSubscriptionDeploymentStack -Name MySubStack -TemplateFile myTemplate.json -Location westus -DenySettingsMode DenyDelete -ActionOnUnmanage DetachAll
```

Validates a subscription scoped Deployment stack named 'MySubStack' in the default subscription, with deny settings being DenyDelete and ActionOnUnmanage as DetachAll.

## PARAMETERS

### -ActionOnUnmanage
Action to take on resources that become unmanaged on deletion or update of the deployment stack.
Possible values include: 'detachAll' (do not delete any unmanaged resources), 'deleteResources' (delete all unmanaged resources that are not RGs or MGs), and 'deleteAll' (delete every unmanaged resource).

```yaml
Type: PSActionOnUnmanage
Parameter Sets: (All)
Aliases:
Accepted values: DetachAll, DeleteResources, DeleteAll

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AsJob
Run cmdlet in the background.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BypassStackOutOfSyncError
Bypass errors for the stack being out of sync when running the operation.
If the stack is out of sync and this parameter is not set, the operation will fail.
Only include this parameter if instructed to do so on a failed stack operation.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DenySettingsApplyToChildScopes
Apply to child scopes.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DenySettingsExcludedAction
List of role-based management operations that are excluded from the denySettings.
Up to 200 actions are permitted.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DenySettingsExcludedPrincipal
List of AAD principal IDs excluded from the lock.
Up to 5 principals are permitted.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DenySettingsMode
Mode for DenySettings.
Possible values include: 'denyDelete', 'denyWriteAndDelete', and 'none'.

```yaml
Type: PSDenySettingsMode
Parameter Sets: (All)
Aliases:
Accepted values: None, DenyDelete, DenyWriteAndDelete

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentResourceGroupName
The ResourceGroup at which the deployment will be created.
If none is specified, it will default to the subscription level scope of the deployment stack.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description for the stack.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Force
Do not ask for confirmation when overwriting an existing stack.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
Location of the stack.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The name of the deploymentStack to create

```yaml
Type: String
Parameter Sets: (All)
Aliases: StackName

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -PassThru
If set, a boolean will be returned with value dependent on cmdlet success.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Pre
When set, indicates that the cmdlet should use pre-release API versions when automatically determining which version to use.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QueryString
The query string (for example, a SAS token) to be used with the TemplateUri parameter.
Would be used in case of linked templates

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkipTemplateParameterPrompt
Skips the PowerShell dynamic parameter processing that checks if the provided template parameter contains all necessary parameters used by the template.
This check would prompt the user to provide a value for the missing parameters, but providing the -SkipTemplateParameterPrompt will ignore this prompt and error out immediately if a parameter was found not to be bound in the template.
For non-interactive scripts, -SkipTemplateParameterPrompt can be provided to provide a better error message in the case where not all required parameters are satisfied.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
The tags to put on the deployment.

```yaml
Type: Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateFile
TemplateFile to be used to create the stack.

```yaml
Type: String
Parameter Sets: ByTemplateFileWithNoParameters, ByTemplateFileWithParameterFile, ByTemplateFileWithParameterUri, ByTemplateFileWithParameterObject
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -TemplateParameterFile
Parameter file to use for the template.

```yaml
Type: String
Parameter Sets: ByTemplateFileWithParameterFile, ByTemplateUriWithParameterFile, ByTemplateSpecWithParameterFile, ByParameterFileWithNoTemplate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -TemplateParameterObject
A hash table which represents the parameters.

```yaml
Type: Hashtable
Parameter Sets: ByTemplateFileWithParameterObject, ByTemplateUriWithParameterObject, ByTemplateSpecWithParameterObject
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -TemplateParameterUri
Location of the Parameter file to use for the template.

```yaml
Type: String
Parameter Sets: ByTemplateFileWithParameterUri, ByTemplateUriWithParameterUri, ByTemplateSpecWithParameterUri
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -TemplateSpecId
ResourceId of the TemplateSpec to be used to create the stack.

```yaml
Type: String
Parameter Sets: ByTemplateSpecWithParameterFile, ByTemplateSpecWithParameterUri, ByTemplateSpecWithParameterObject, ByTemplateSpecWithNoParameters
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -TemplateUri
Location of the Template to be used to create the stack.

```yaml
Type: String
Parameter Sets: ByTemplateUriWithParameterFile, ByTemplateUriWithParameterUri, ByTemplateUriWithParameterObject, ByTemplateUriWithNoParameters
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String

### System.Collections.Hashtable

## OUTPUTS

### System.Boolean

## NOTES

## RELATED LINKS
