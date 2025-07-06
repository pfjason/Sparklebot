# Org.OpenAPITools.Api.PipelinesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPipelineApiV1PipelinesAddPost**](PipelinesApi.md#addpipelineapiv1pipelinesaddpost) | **POST** /api/v1/pipelines/add | Add Pipeline |
| [**DeletePipelineApiV1PipelinesDeleteDelete**](PipelinesApi.md#deletepipelineapiv1pipelinesdeletedelete) | **DELETE** /api/v1/pipelines/delete | Delete Pipeline |
| [**GetPipelineValvesApiV1PipelinesPipelineIdValvesGet**](PipelinesApi.md#getpipelinevalvesapiv1pipelinespipelineidvalvesget) | **GET** /api/v1/pipelines/{pipeline_id}/valves | Get Pipeline Valves |
| [**GetPipelineValvesSpecApiV1PipelinesPipelineIdValvesSpecGet**](PipelinesApi.md#getpipelinevalvesspecapiv1pipelinespipelineidvalvesspecget) | **GET** /api/v1/pipelines/{pipeline_id}/valves/spec | Get Pipeline Valves Spec |
| [**GetPipelinesApiV1PipelinesGet**](PipelinesApi.md#getpipelinesapiv1pipelinesget) | **GET** /api/v1/pipelines/ | Get Pipelines |
| [**GetPipelinesListApiV1PipelinesListGet**](PipelinesApi.md#getpipelineslistapiv1pipelineslistget) | **GET** /api/v1/pipelines/list | Get Pipelines List |
| [**UpdatePipelineValvesApiV1PipelinesPipelineIdValvesUpdatePost**](PipelinesApi.md#updatepipelinevalvesapiv1pipelinespipelineidvalvesupdatepost) | **POST** /api/v1/pipelines/{pipeline_id}/valves/update | Update Pipeline Valves |
| [**UploadPipelineApiV1PipelinesUploadPost**](PipelinesApi.md#uploadpipelineapiv1pipelinesuploadpost) | **POST** /api/v1/pipelines/upload | Upload Pipeline |

<a id="addpipelineapiv1pipelinesaddpost"></a>
# **AddPipelineApiV1PipelinesAddPost**
> Object AddPipelineApiV1PipelinesAddPost (AddPipelineForm addPipelineForm)

Add Pipeline


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addPipelineForm** | [**AddPipelineForm**](AddPipelineForm.md) |  |  |

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

<a id="deletepipelineapiv1pipelinesdeletedelete"></a>
# **DeletePipelineApiV1PipelinesDeleteDelete**
> Object DeletePipelineApiV1PipelinesDeleteDelete (DeletePipelineForm deletePipelineForm)

Delete Pipeline


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deletePipelineForm** | [**DeletePipelineForm**](DeletePipelineForm.md) |  |  |

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

<a id="getpipelinevalvesapiv1pipelinespipelineidvalvesget"></a>
# **GetPipelineValvesApiV1PipelinesPipelineIdValvesGet**
> Object GetPipelineValvesApiV1PipelinesPipelineIdValvesGet (string pipelineId, int urlIdx)

Get Pipeline Valves


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pipelineId** | **string** |  |  |
| **urlIdx** | **int** |  |  |

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

<a id="getpipelinevalvesspecapiv1pipelinespipelineidvalvesspecget"></a>
# **GetPipelineValvesSpecApiV1PipelinesPipelineIdValvesSpecGet**
> Object GetPipelineValvesSpecApiV1PipelinesPipelineIdValvesSpecGet (string pipelineId, int urlIdx)

Get Pipeline Valves Spec


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pipelineId** | **string** |  |  |
| **urlIdx** | **int** |  |  |

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

<a id="getpipelinesapiv1pipelinesget"></a>
# **GetPipelinesApiV1PipelinesGet**
> Object GetPipelinesApiV1PipelinesGet (int urlIdx = null)

Get Pipelines


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlIdx** | **int** |  | [optional]  |

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

<a id="getpipelineslistapiv1pipelineslistget"></a>
# **GetPipelinesListApiV1PipelinesListGet**
> Object GetPipelinesListApiV1PipelinesListGet ()

Get Pipelines List


### Parameters
This endpoint does not need any parameter.
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatepipelinevalvesapiv1pipelinespipelineidvalvesupdatepost"></a>
# **UpdatePipelineValvesApiV1PipelinesPipelineIdValvesUpdatePost**
> Object UpdatePipelineValvesApiV1PipelinesPipelineIdValvesUpdatePost (string pipelineId, Object body, int urlIdx)

Update Pipeline Valves


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pipelineId** | **string** |  |  |
| **body** | **Object** |  |  |
| **urlIdx** | **int** |  |  |

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

<a id="uploadpipelineapiv1pipelinesuploadpost"></a>
# **UploadPipelineApiV1PipelinesUploadPost**
> Object UploadPipelineApiV1PipelinesUploadPost (int urlIdx, System.IO.Stream file)

Upload Pipeline


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlIdx** | **int** |  |  |
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

