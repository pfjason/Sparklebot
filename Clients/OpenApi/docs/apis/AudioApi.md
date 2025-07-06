# Org.OpenAPITools.Api.AudioApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAudioConfigApiV1AudioConfigGet**](AudioApi.md#getaudioconfigapiv1audioconfigget) | **GET** /api/v1/audio/config | Get Audio Config |
| [**GetModelsApiV1AudioModelsGet**](AudioApi.md#getmodelsapiv1audiomodelsget) | **GET** /api/v1/audio/models | Get Models |
| [**GetVoicesApiV1AudioVoicesGet**](AudioApi.md#getvoicesapiv1audiovoicesget) | **GET** /api/v1/audio/voices | Get Voices |
| [**SpeechApiV1AudioSpeechPost**](AudioApi.md#speechapiv1audiospeechpost) | **POST** /api/v1/audio/speech | Speech |
| [**TranscriptionApiV1AudioTranscriptionsPost**](AudioApi.md#transcriptionapiv1audiotranscriptionspost) | **POST** /api/v1/audio/transcriptions | Transcription |
| [**UpdateAudioConfigApiV1AudioConfigUpdatePost**](AudioApi.md#updateaudioconfigapiv1audioconfigupdatepost) | **POST** /api/v1/audio/config/update | Update Audio Config |

<a id="getaudioconfigapiv1audioconfigget"></a>
# **GetAudioConfigApiV1AudioConfigGet**
> Object GetAudioConfigApiV1AudioConfigGet ()

Get Audio Config


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

<a id="getmodelsapiv1audiomodelsget"></a>
# **GetModelsApiV1AudioModelsGet**
> Object GetModelsApiV1AudioModelsGet ()

Get Models


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

<a id="getvoicesapiv1audiovoicesget"></a>
# **GetVoicesApiV1AudioVoicesGet**
> Object GetVoicesApiV1AudioVoicesGet ()

Get Voices


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

<a id="speechapiv1audiospeechpost"></a>
# **SpeechApiV1AudioSpeechPost**
> Object SpeechApiV1AudioSpeechPost ()

Speech


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

<a id="transcriptionapiv1audiotranscriptionspost"></a>
# **TranscriptionApiV1AudioTranscriptionsPost**
> Object TranscriptionApiV1AudioTranscriptionsPost (System.IO.Stream file, string language = null)

Transcription


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |
| **language** | **string** |  | [optional]  |

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

<a id="updateaudioconfigapiv1audioconfigupdatepost"></a>
# **UpdateAudioConfigApiV1AudioConfigUpdatePost**
> Object UpdateAudioConfigApiV1AudioConfigUpdatePost (AudioConfigUpdateForm audioConfigUpdateForm)

Update Audio Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **audioConfigUpdateForm** | [**AudioConfigUpdateForm**](AudioConfigUpdateForm.md) |  |  |

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

