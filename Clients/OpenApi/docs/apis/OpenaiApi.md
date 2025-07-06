# Org.OpenAPITools.Api.OpenaiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateChatCompletionOpenaiChatCompletionsPost**](OpenaiApi.md#generatechatcompletionopenaichatcompletionspost) | **POST** /openai/chat/completions | Generate Chat Completion |
| [**GetConfigOpenaiConfigGet**](OpenaiApi.md#getconfigopenaiconfigget) | **GET** /openai/config | Get Config |
| [**GetModelsOpenaiModelsGet**](OpenaiApi.md#getmodelsopenaimodelsget) | **GET** /openai/models | Get Models |
| [**GetModelsOpenaiModelsUrlIdxGet**](OpenaiApi.md#getmodelsopenaimodelsurlidxget) | **GET** /openai/models/{url_idx} | Get Models |
| [**ProxyOpenaiPathDelete**](OpenaiApi.md#proxyopenaipathdelete) | **GET** /openai/{path} | Proxy |
| [**ProxyOpenaiPathDelete_0**](OpenaiApi.md#proxyopenaipathdelete_0) | **PUT** /openai/{path} | Proxy |
| [**ProxyOpenaiPathDelete_1**](OpenaiApi.md#proxyopenaipathdelete_1) | **POST** /openai/{path} | Proxy |
| [**ProxyOpenaiPathDelete_2**](OpenaiApi.md#proxyopenaipathdelete_2) | **DELETE** /openai/{path} | Proxy |
| [**SpeechOpenaiAudioSpeechPost**](OpenaiApi.md#speechopenaiaudiospeechpost) | **POST** /openai/audio/speech | Speech |
| [**UpdateConfigOpenaiConfigUpdatePost**](OpenaiApi.md#updateconfigopenaiconfigupdatepost) | **POST** /openai/config/update | Update Config |
| [**VerifyConnectionOpenaiVerifyPost**](OpenaiApi.md#verifyconnectionopenaiverifypost) | **POST** /openai/verify | Verify Connection |

<a id="generatechatcompletionopenaichatcompletionspost"></a>
# **GenerateChatCompletionOpenaiChatCompletionsPost**
> Object GenerateChatCompletionOpenaiChatCompletionsPost (Object body, bool bypassFilter = null)

Generate Chat Completion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |
| **bypassFilter** | **bool** |  | [optional]  |

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

<a id="getconfigopenaiconfigget"></a>
# **GetConfigOpenaiConfigGet**
> Object GetConfigOpenaiConfigGet ()

Get Config


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

<a id="getmodelsopenaimodelsget"></a>
# **GetModelsOpenaiModelsGet**
> Object GetModelsOpenaiModelsGet (int urlIdx = null)

Get Models


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

<a id="getmodelsopenaimodelsurlidxget"></a>
# **GetModelsOpenaiModelsUrlIdxGet**
> Object GetModelsOpenaiModelsUrlIdxGet (int urlIdx)

Get Models


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="proxyopenaipathdelete"></a>
# **ProxyOpenaiPathDelete**
> Object ProxyOpenaiPathDelete (string path)

Proxy

Deprecated: proxy all requests to OpenAI API


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** |  |  |

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

<a id="proxyopenaipathdelete_0"></a>
# **ProxyOpenaiPathDelete_0**
> Object ProxyOpenaiPathDelete_0 (string path)

Proxy

Deprecated: proxy all requests to OpenAI API


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** |  |  |

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

<a id="proxyopenaipathdelete_1"></a>
# **ProxyOpenaiPathDelete_1**
> Object ProxyOpenaiPathDelete_1 (string path)

Proxy

Deprecated: proxy all requests to OpenAI API


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** |  |  |

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

<a id="proxyopenaipathdelete_2"></a>
# **ProxyOpenaiPathDelete_2**
> Object ProxyOpenaiPathDelete_2 (string path)

Proxy

Deprecated: proxy all requests to OpenAI API


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** |  |  |

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

<a id="speechopenaiaudiospeechpost"></a>
# **SpeechOpenaiAudioSpeechPost**
> Object SpeechOpenaiAudioSpeechPost ()

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

<a id="updateconfigopenaiconfigupdatepost"></a>
# **UpdateConfigOpenaiConfigUpdatePost**
> Object UpdateConfigOpenaiConfigUpdatePost (OpenWebuiRoutersOpenaiOpenAIConfigForm openWebuiRoutersOpenaiOpenAIConfigForm)

Update Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **openWebuiRoutersOpenaiOpenAIConfigForm** | [**OpenWebuiRoutersOpenaiOpenAIConfigForm**](OpenWebuiRoutersOpenaiOpenAIConfigForm.md) |  |  |

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

<a id="verifyconnectionopenaiverifypost"></a>
# **VerifyConnectionOpenaiVerifyPost**
> Object VerifyConnectionOpenaiVerifyPost (OpenWebuiRoutersOpenaiConnectionVerificationForm openWebuiRoutersOpenaiConnectionVerificationForm)

Verify Connection


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **openWebuiRoutersOpenaiConnectionVerificationForm** | [**OpenWebuiRoutersOpenaiConnectionVerificationForm**](OpenWebuiRoutersOpenaiConnectionVerificationForm.md) |  |  |

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

