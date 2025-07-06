# Org.OpenAPITools.Api.FunctionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewFunctionApiV1FunctionsCreatePost**](FunctionsApi.md#createnewfunctionapiv1functionscreatepost) | **POST** /api/v1/functions/create | Create New Function |
| [**DeleteFunctionByIdApiV1FunctionsIdIdDeleteDelete**](FunctionsApi.md#deletefunctionbyidapiv1functionsididdeletedelete) | **DELETE** /api/v1/functions/id/{id}/delete | Delete Function By Id |
| [**GetFunctionByIdApiV1FunctionsIdIdGet**](FunctionsApi.md#getfunctionbyidapiv1functionsididget) | **GET** /api/v1/functions/id/{id} | Get Function By Id |
| [**GetFunctionUserValvesByIdApiV1FunctionsIdIdValvesUserGet**](FunctionsApi.md#getfunctionuservalvesbyidapiv1functionsididvalvesuserget) | **GET** /api/v1/functions/id/{id}/valves/user | Get Function User Valves By Id |
| [**GetFunctionUserValvesSpecByIdApiV1FunctionsIdIdValvesUserSpecGet**](FunctionsApi.md#getfunctionuservalvesspecbyidapiv1functionsididvalvesuserspecget) | **GET** /api/v1/functions/id/{id}/valves/user/spec | Get Function User Valves Spec By Id |
| [**GetFunctionValvesByIdApiV1FunctionsIdIdValvesGet**](FunctionsApi.md#getfunctionvalvesbyidapiv1functionsididvalvesget) | **GET** /api/v1/functions/id/{id}/valves | Get Function Valves By Id |
| [**GetFunctionValvesSpecByIdApiV1FunctionsIdIdValvesSpecGet**](FunctionsApi.md#getfunctionvalvesspecbyidapiv1functionsididvalvesspecget) | **GET** /api/v1/functions/id/{id}/valves/spec | Get Function Valves Spec By Id |
| [**GetFunctionsApiV1FunctionsExportGet**](FunctionsApi.md#getfunctionsapiv1functionsexportget) | **GET** /api/v1/functions/export | Get Functions |
| [**GetFunctionsApiV1FunctionsGet**](FunctionsApi.md#getfunctionsapiv1functionsget) | **GET** /api/v1/functions/ | Get Functions |
| [**LoadFunctionFromUrlApiV1FunctionsLoadUrlPost**](FunctionsApi.md#loadfunctionfromurlapiv1functionsloadurlpost) | **POST** /api/v1/functions/load/url | Load Function From Url |
| [**SyncFunctionsApiV1FunctionsSyncPost**](FunctionsApi.md#syncfunctionsapiv1functionssyncpost) | **POST** /api/v1/functions/sync | Sync Functions |
| [**ToggleFunctionByIdApiV1FunctionsIdIdTogglePost**](FunctionsApi.md#togglefunctionbyidapiv1functionsididtogglepost) | **POST** /api/v1/functions/id/{id}/toggle | Toggle Function By Id |
| [**ToggleGlobalByIdApiV1FunctionsIdIdToggleGlobalPost**](FunctionsApi.md#toggleglobalbyidapiv1functionsididtoggleglobalpost) | **POST** /api/v1/functions/id/{id}/toggle/global | Toggle Global By Id |
| [**UpdateFunctionByIdApiV1FunctionsIdIdUpdatePost**](FunctionsApi.md#updatefunctionbyidapiv1functionsididupdatepost) | **POST** /api/v1/functions/id/{id}/update | Update Function By Id |
| [**UpdateFunctionUserValvesByIdApiV1FunctionsIdIdValvesUserUpdatePost**](FunctionsApi.md#updatefunctionuservalvesbyidapiv1functionsididvalvesuserupdatepost) | **POST** /api/v1/functions/id/{id}/valves/user/update | Update Function User Valves By Id |
| [**UpdateFunctionValvesByIdApiV1FunctionsIdIdValvesUpdatePost**](FunctionsApi.md#updatefunctionvalvesbyidapiv1functionsididvalvesupdatepost) | **POST** /api/v1/functions/id/{id}/valves/update | Update Function Valves By Id |

<a id="createnewfunctionapiv1functionscreatepost"></a>
# **CreateNewFunctionApiV1FunctionsCreatePost**
> FunctionResponse CreateNewFunctionApiV1FunctionsCreatePost (FunctionForm functionForm)

Create New Function


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **functionForm** | [**FunctionForm**](FunctionForm.md) |  |  |

### Return type

[**FunctionResponse**](FunctionResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletefunctionbyidapiv1functionsididdeletedelete"></a>
# **DeleteFunctionByIdApiV1FunctionsIdIdDeleteDelete**
> bool DeleteFunctionByIdApiV1FunctionsIdIdDeleteDelete (string id)

Delete Function By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**bool**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfunctionbyidapiv1functionsididget"></a>
# **GetFunctionByIdApiV1FunctionsIdIdGet**
> FunctionModel GetFunctionByIdApiV1FunctionsIdIdGet (string id)

Get Function By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**FunctionModel**](FunctionModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfunctionuservalvesbyidapiv1functionsididvalvesuserget"></a>
# **GetFunctionUserValvesByIdApiV1FunctionsIdIdValvesUserGet**
> Object GetFunctionUserValvesByIdApiV1FunctionsIdIdValvesUserGet (string id)

Get Function User Valves By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfunctionuservalvesspecbyidapiv1functionsididvalvesuserspecget"></a>
# **GetFunctionUserValvesSpecByIdApiV1FunctionsIdIdValvesUserSpecGet**
> Object GetFunctionUserValvesSpecByIdApiV1FunctionsIdIdValvesUserSpecGet (string id)

Get Function User Valves Spec By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfunctionvalvesbyidapiv1functionsididvalvesget"></a>
# **GetFunctionValvesByIdApiV1FunctionsIdIdValvesGet**
> Object GetFunctionValvesByIdApiV1FunctionsIdIdValvesGet (string id)

Get Function Valves By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfunctionvalvesspecbyidapiv1functionsididvalvesspecget"></a>
# **GetFunctionValvesSpecByIdApiV1FunctionsIdIdValvesSpecGet**
> Object GetFunctionValvesSpecByIdApiV1FunctionsIdIdValvesSpecGet (string id)

Get Function Valves Spec By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfunctionsapiv1functionsexportget"></a>
# **GetFunctionsApiV1FunctionsExportGet**
> List&lt;FunctionModel&gt; GetFunctionsApiV1FunctionsExportGet ()

Get Functions


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FunctionModel&gt;**](FunctionModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfunctionsapiv1functionsget"></a>
# **GetFunctionsApiV1FunctionsGet**
> List&lt;FunctionResponse&gt; GetFunctionsApiV1FunctionsGet ()

Get Functions


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FunctionResponse&gt;**](FunctionResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="loadfunctionfromurlapiv1functionsloadurlpost"></a>
# **LoadFunctionFromUrlApiV1FunctionsLoadUrlPost**
> Object LoadFunctionFromUrlApiV1FunctionsLoadUrlPost (LoadUrlForm loadUrlForm)

Load Function From Url


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loadUrlForm** | [**LoadUrlForm**](LoadUrlForm.md) |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="syncfunctionsapiv1functionssyncpost"></a>
# **SyncFunctionsApiV1FunctionsSyncPost**
> FunctionModel SyncFunctionsApiV1FunctionsSyncPost (SyncFunctionsForm syncFunctionsForm)

Sync Functions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **syncFunctionsForm** | [**SyncFunctionsForm**](SyncFunctionsForm.md) |  |  |

### Return type

[**FunctionModel**](FunctionModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="togglefunctionbyidapiv1functionsididtogglepost"></a>
# **ToggleFunctionByIdApiV1FunctionsIdIdTogglePost**
> FunctionModel ToggleFunctionByIdApiV1FunctionsIdIdTogglePost (string id)

Toggle Function By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**FunctionModel**](FunctionModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="toggleglobalbyidapiv1functionsididtoggleglobalpost"></a>
# **ToggleGlobalByIdApiV1FunctionsIdIdToggleGlobalPost**
> FunctionModel ToggleGlobalByIdApiV1FunctionsIdIdToggleGlobalPost (string id)

Toggle Global By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**FunctionModel**](FunctionModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatefunctionbyidapiv1functionsididupdatepost"></a>
# **UpdateFunctionByIdApiV1FunctionsIdIdUpdatePost**
> FunctionModel UpdateFunctionByIdApiV1FunctionsIdIdUpdatePost (string id, FunctionForm functionForm)

Update Function By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **functionForm** | [**FunctionForm**](FunctionForm.md) |  |  |

### Return type

[**FunctionModel**](FunctionModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatefunctionuservalvesbyidapiv1functionsididvalvesuserupdatepost"></a>
# **UpdateFunctionUserValvesByIdApiV1FunctionsIdIdValvesUserUpdatePost**
> Object UpdateFunctionUserValvesByIdApiV1FunctionsIdIdValvesUserUpdatePost (string id, Object body)

Update Function User Valves By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **body** | **Object** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatefunctionvalvesbyidapiv1functionsididvalvesupdatepost"></a>
# **UpdateFunctionValvesByIdApiV1FunctionsIdIdValvesUpdatePost**
> Object UpdateFunctionValvesByIdApiV1FunctionsIdIdValvesUpdatePost (string id, Object body)

Update Function Valves By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **body** | **Object** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

