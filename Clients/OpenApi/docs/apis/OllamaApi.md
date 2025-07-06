# Org.OpenAPITools.Api.OllamaApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CopyModelOllamaApiCopyPost**](OllamaApi.md#copymodelollamaapicopypost) | **POST** /ollama/api/copy | Copy Model |
| [**CopyModelOllamaApiCopyUrlIdxPost**](OllamaApi.md#copymodelollamaapicopyurlidxpost) | **POST** /ollama/api/copy/{url_idx} | Copy Model |
| [**CreateModelOllamaApiCreatePost**](OllamaApi.md#createmodelollamaapicreatepost) | **POST** /ollama/api/create | Create Model |
| [**CreateModelOllamaApiCreateUrlIdxPost**](OllamaApi.md#createmodelollamaapicreateurlidxpost) | **POST** /ollama/api/create/{url_idx} | Create Model |
| [**DeleteModelOllamaApiDeleteDelete**](OllamaApi.md#deletemodelollamaapideletedelete) | **DELETE** /ollama/api/delete | Delete Model |
| [**DeleteModelOllamaApiDeleteUrlIdxDelete**](OllamaApi.md#deletemodelollamaapideleteurlidxdelete) | **DELETE** /ollama/api/delete/{url_idx} | Delete Model |
| [**DownloadModelOllamaModelsDownloadPost**](OllamaApi.md#downloadmodelollamamodelsdownloadpost) | **POST** /ollama/models/download | Download Model |
| [**DownloadModelOllamaModelsDownloadUrlIdxPost**](OllamaApi.md#downloadmodelollamamodelsdownloadurlidxpost) | **POST** /ollama/models/download/{url_idx} | Download Model |
| [**EmbedOllamaApiEmbedPost**](OllamaApi.md#embedollamaapiembedpost) | **POST** /ollama/api/embed | Embed |
| [**EmbedOllamaApiEmbedUrlIdxPost**](OllamaApi.md#embedollamaapiembedurlidxpost) | **POST** /ollama/api/embed/{url_idx} | Embed |
| [**EmbeddingsOllamaApiEmbeddingsPost**](OllamaApi.md#embeddingsollamaapiembeddingspost) | **POST** /ollama/api/embeddings | Embeddings |
| [**EmbeddingsOllamaApiEmbeddingsUrlIdxPost**](OllamaApi.md#embeddingsollamaapiembeddingsurlidxpost) | **POST** /ollama/api/embeddings/{url_idx} | Embeddings |
| [**GenerateChatCompletionOllamaApiChatPost**](OllamaApi.md#generatechatcompletionollamaapichatpost) | **POST** /ollama/api/chat | Generate Chat Completion |
| [**GenerateChatCompletionOllamaApiChatUrlIdxPost**](OllamaApi.md#generatechatcompletionollamaapichaturlidxpost) | **POST** /ollama/api/chat/{url_idx} | Generate Chat Completion |
| [**GenerateCompletionOllamaApiGeneratePost**](OllamaApi.md#generatecompletionollamaapigeneratepost) | **POST** /ollama/api/generate | Generate Completion |
| [**GenerateCompletionOllamaApiGenerateUrlIdxPost**](OllamaApi.md#generatecompletionollamaapigenerateurlidxpost) | **POST** /ollama/api/generate/{url_idx} | Generate Completion |
| [**GenerateOpenaiChatCompletionOllamaV1ChatCompletionsPost**](OllamaApi.md#generateopenaichatcompletionollamav1chatcompletionspost) | **POST** /ollama/v1/chat/completions | Generate Openai Chat Completion |
| [**GenerateOpenaiChatCompletionOllamaV1ChatCompletionsUrlIdxPost**](OllamaApi.md#generateopenaichatcompletionollamav1chatcompletionsurlidxpost) | **POST** /ollama/v1/chat/completions/{url_idx} | Generate Openai Chat Completion |
| [**GenerateOpenaiCompletionOllamaV1CompletionsPost**](OllamaApi.md#generateopenaicompletionollamav1completionspost) | **POST** /ollama/v1/completions | Generate Openai Completion |
| [**GenerateOpenaiCompletionOllamaV1CompletionsUrlIdxPost**](OllamaApi.md#generateopenaicompletionollamav1completionsurlidxpost) | **POST** /ollama/v1/completions/{url_idx} | Generate Openai Completion |
| [**GetConfigOllamaConfigGet**](OllamaApi.md#getconfigollamaconfigget) | **GET** /ollama/config | Get Config |
| [**GetOllamaLoadedModelsOllamaApiPsGet**](OllamaApi.md#getollamaloadedmodelsollamaapipsget) | **GET** /ollama/api/ps | Get Ollama Loaded Models |
| [**GetOllamaTagsOllamaApiTagsGet**](OllamaApi.md#getollamatagsollamaapitagsget) | **GET** /ollama/api/tags | Get Ollama Tags |
| [**GetOllamaTagsOllamaApiTagsUrlIdxGet**](OllamaApi.md#getollamatagsollamaapitagsurlidxget) | **GET** /ollama/api/tags/{url_idx} | Get Ollama Tags |
| [**GetOllamaVersionsOllamaApiVersionGet**](OllamaApi.md#getollamaversionsollamaapiversionget) | **GET** /ollama/api/version | Get Ollama Versions |
| [**GetOllamaVersionsOllamaApiVersionUrlIdxGet**](OllamaApi.md#getollamaversionsollamaapiversionurlidxget) | **GET** /ollama/api/version/{url_idx} | Get Ollama Versions |
| [**GetOpenaiModelsOllamaV1ModelsGet**](OllamaApi.md#getopenaimodelsollamav1modelsget) | **GET** /ollama/v1/models | Get Openai Models |
| [**GetOpenaiModelsOllamaV1ModelsUrlIdxGet**](OllamaApi.md#getopenaimodelsollamav1modelsurlidxget) | **GET** /ollama/v1/models/{url_idx} | Get Openai Models |
| [**GetStatusOllamaGet**](OllamaApi.md#getstatusollamaget) | **GET** /ollama/ | Get Status |
| [**GetStatusOllamaHead**](OllamaApi.md#getstatusollamahead) | **HEAD** /ollama/ | Get Status |
| [**PullModelOllamaApiPullPost**](OllamaApi.md#pullmodelollamaapipullpost) | **POST** /ollama/api/pull | Pull Model |
| [**PullModelOllamaApiPullUrlIdxPost**](OllamaApi.md#pullmodelollamaapipullurlidxpost) | **POST** /ollama/api/pull/{url_idx} | Pull Model |
| [**PushModelOllamaApiPushDelete**](OllamaApi.md#pushmodelollamaapipushdelete) | **DELETE** /ollama/api/push | Push Model |
| [**PushModelOllamaApiPushUrlIdxDelete**](OllamaApi.md#pushmodelollamaapipushurlidxdelete) | **DELETE** /ollama/api/push/{url_idx} | Push Model |
| [**ShowModelInfoOllamaApiShowPost**](OllamaApi.md#showmodelinfoollamaapishowpost) | **POST** /ollama/api/show | Show Model Info |
| [**UnloadModelOllamaApiUnloadPost**](OllamaApi.md#unloadmodelollamaapiunloadpost) | **POST** /ollama/api/unload | Unload Model |
| [**UpdateConfigOllamaConfigUpdatePost**](OllamaApi.md#updateconfigollamaconfigupdatepost) | **POST** /ollama/config/update | Update Config |
| [**UploadModelOllamaModelsUploadPost**](OllamaApi.md#uploadmodelollamamodelsuploadpost) | **POST** /ollama/models/upload | Upload Model |
| [**UploadModelOllamaModelsUploadUrlIdxPost**](OllamaApi.md#uploadmodelollamamodelsuploadurlidxpost) | **POST** /ollama/models/upload/{url_idx} | Upload Model |
| [**VerifyConnectionOllamaVerifyPost**](OllamaApi.md#verifyconnectionollamaverifypost) | **POST** /ollama/verify | Verify Connection |

<a id="copymodelollamaapicopypost"></a>
# **CopyModelOllamaApiCopyPost**
> Object CopyModelOllamaApiCopyPost (CopyModelForm copyModelForm, int urlIdx = null)

Copy Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **copyModelForm** | [**CopyModelForm**](CopyModelForm.md) |  |  |
| **urlIdx** | **int** |  | [optional]  |

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

<a id="copymodelollamaapicopyurlidxpost"></a>
# **CopyModelOllamaApiCopyUrlIdxPost**
> Object CopyModelOllamaApiCopyUrlIdxPost (CopyModelForm copyModelForm, int urlIdx)

Copy Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **copyModelForm** | [**CopyModelForm**](CopyModelForm.md) |  |  |
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

<a id="createmodelollamaapicreatepost"></a>
# **CreateModelOllamaApiCreatePost**
> Object CreateModelOllamaApiCreatePost (CreateModelForm createModelForm, int urlIdx = null)

Create Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createModelForm** | [**CreateModelForm**](CreateModelForm.md) |  |  |
| **urlIdx** | **int** |  | [optional] [default to 0] |

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

<a id="createmodelollamaapicreateurlidxpost"></a>
# **CreateModelOllamaApiCreateUrlIdxPost**
> Object CreateModelOllamaApiCreateUrlIdxPost (int urlIdx, CreateModelForm createModelForm)

Create Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlIdx** | **int** |  |  |
| **createModelForm** | [**CreateModelForm**](CreateModelForm.md) |  |  |

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

<a id="deletemodelollamaapideletedelete"></a>
# **DeleteModelOllamaApiDeleteDelete**
> Object DeleteModelOllamaApiDeleteDelete (ModelNameForm modelNameForm, int urlIdx = null)

Delete Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelNameForm** | [**ModelNameForm**](ModelNameForm.md) |  |  |
| **urlIdx** | **int** |  | [optional]  |

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

<a id="deletemodelollamaapideleteurlidxdelete"></a>
# **DeleteModelOllamaApiDeleteUrlIdxDelete**
> Object DeleteModelOllamaApiDeleteUrlIdxDelete (ModelNameForm modelNameForm, int urlIdx)

Delete Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelNameForm** | [**ModelNameForm**](ModelNameForm.md) |  |  |
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

<a id="downloadmodelollamamodelsdownloadpost"></a>
# **DownloadModelOllamaModelsDownloadPost**
> Object DownloadModelOllamaModelsDownloadPost (UrlForm urlForm, int urlIdx = null)

Download Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlForm** | [**UrlForm**](UrlForm.md) |  |  |
| **urlIdx** | **int** |  | [optional]  |

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

<a id="downloadmodelollamamodelsdownloadurlidxpost"></a>
# **DownloadModelOllamaModelsDownloadUrlIdxPost**
> Object DownloadModelOllamaModelsDownloadUrlIdxPost (UrlForm urlForm, int urlIdx)

Download Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlForm** | [**UrlForm**](UrlForm.md) |  |  |
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

<a id="embedollamaapiembedpost"></a>
# **EmbedOllamaApiEmbedPost**
> Object EmbedOllamaApiEmbedPost (GenerateEmbedForm generateEmbedForm, int urlIdx = null)

Embed


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateEmbedForm** | [**GenerateEmbedForm**](GenerateEmbedForm.md) |  |  |
| **urlIdx** | **int** |  | [optional]  |

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

<a id="embedollamaapiembedurlidxpost"></a>
# **EmbedOllamaApiEmbedUrlIdxPost**
> Object EmbedOllamaApiEmbedUrlIdxPost (GenerateEmbedForm generateEmbedForm, int urlIdx)

Embed


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateEmbedForm** | [**GenerateEmbedForm**](GenerateEmbedForm.md) |  |  |
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

<a id="embeddingsollamaapiembeddingspost"></a>
# **EmbeddingsOllamaApiEmbeddingsPost**
> Object EmbeddingsOllamaApiEmbeddingsPost (GenerateEmbeddingsForm generateEmbeddingsForm, int urlIdx = null)

Embeddings


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateEmbeddingsForm** | [**GenerateEmbeddingsForm**](GenerateEmbeddingsForm.md) |  |  |
| **urlIdx** | **int** |  | [optional]  |

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

<a id="embeddingsollamaapiembeddingsurlidxpost"></a>
# **EmbeddingsOllamaApiEmbeddingsUrlIdxPost**
> Object EmbeddingsOllamaApiEmbeddingsUrlIdxPost (GenerateEmbeddingsForm generateEmbeddingsForm, int urlIdx)

Embeddings


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateEmbeddingsForm** | [**GenerateEmbeddingsForm**](GenerateEmbeddingsForm.md) |  |  |
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

<a id="generatechatcompletionollamaapichatpost"></a>
# **GenerateChatCompletionOllamaApiChatPost**
> Object GenerateChatCompletionOllamaApiChatPost (Object body, int urlIdx = null, bool bypassFilter = null)

Generate Chat Completion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |
| **urlIdx** | **int** |  | [optional]  |
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

<a id="generatechatcompletionollamaapichaturlidxpost"></a>
# **GenerateChatCompletionOllamaApiChatUrlIdxPost**
> Object GenerateChatCompletionOllamaApiChatUrlIdxPost (Object body, int urlIdx, bool bypassFilter = null)

Generate Chat Completion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |
| **urlIdx** | **int** |  |  |
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

<a id="generatecompletionollamaapigeneratepost"></a>
# **GenerateCompletionOllamaApiGeneratePost**
> Object GenerateCompletionOllamaApiGeneratePost (GenerateCompletionForm generateCompletionForm, int urlIdx = null)

Generate Completion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateCompletionForm** | [**GenerateCompletionForm**](GenerateCompletionForm.md) |  |  |
| **urlIdx** | **int** |  | [optional]  |

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

<a id="generatecompletionollamaapigenerateurlidxpost"></a>
# **GenerateCompletionOllamaApiGenerateUrlIdxPost**
> Object GenerateCompletionOllamaApiGenerateUrlIdxPost (GenerateCompletionForm generateCompletionForm, int urlIdx)

Generate Completion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateCompletionForm** | [**GenerateCompletionForm**](GenerateCompletionForm.md) |  |  |
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

<a id="generateopenaichatcompletionollamav1chatcompletionspost"></a>
# **GenerateOpenaiChatCompletionOllamaV1ChatCompletionsPost**
> Object GenerateOpenaiChatCompletionOllamaV1ChatCompletionsPost (Object body, int urlIdx = null)

Generate Openai Chat Completion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |
| **urlIdx** | **int** |  | [optional]  |

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

<a id="generateopenaichatcompletionollamav1chatcompletionsurlidxpost"></a>
# **GenerateOpenaiChatCompletionOllamaV1ChatCompletionsUrlIdxPost**
> Object GenerateOpenaiChatCompletionOllamaV1ChatCompletionsUrlIdxPost (Object body, int urlIdx)

Generate Openai Chat Completion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="generateopenaicompletionollamav1completionspost"></a>
# **GenerateOpenaiCompletionOllamaV1CompletionsPost**
> Object GenerateOpenaiCompletionOllamaV1CompletionsPost (Object body, int urlIdx = null)

Generate Openai Completion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |
| **urlIdx** | **int** |  | [optional]  |

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

<a id="generateopenaicompletionollamav1completionsurlidxpost"></a>
# **GenerateOpenaiCompletionOllamaV1CompletionsUrlIdxPost**
> Object GenerateOpenaiCompletionOllamaV1CompletionsUrlIdxPost (Object body, int urlIdx)

Generate Openai Completion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="getconfigollamaconfigget"></a>
# **GetConfigOllamaConfigGet**
> Object GetConfigOllamaConfigGet ()

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

<a id="getollamaloadedmodelsollamaapipsget"></a>
# **GetOllamaLoadedModelsOllamaApiPsGet**
> Object GetOllamaLoadedModelsOllamaApiPsGet ()

Get Ollama Loaded Models

List models that are currently loaded into Ollama memory, and which node they are loaded on.


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

<a id="getollamatagsollamaapitagsget"></a>
# **GetOllamaTagsOllamaApiTagsGet**
> Object GetOllamaTagsOllamaApiTagsGet (int urlIdx = null)

Get Ollama Tags


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

<a id="getollamatagsollamaapitagsurlidxget"></a>
# **GetOllamaTagsOllamaApiTagsUrlIdxGet**
> Object GetOllamaTagsOllamaApiTagsUrlIdxGet (int urlIdx)

Get Ollama Tags


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

<a id="getollamaversionsollamaapiversionget"></a>
# **GetOllamaVersionsOllamaApiVersionGet**
> Object GetOllamaVersionsOllamaApiVersionGet (int urlIdx = null)

Get Ollama Versions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlIdx** | **int** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getollamaversionsollamaapiversionurlidxget"></a>
# **GetOllamaVersionsOllamaApiVersionUrlIdxGet**
> Object GetOllamaVersionsOllamaApiVersionUrlIdxGet (int urlIdx)

Get Ollama Versions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlIdx** | **int** |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getopenaimodelsollamav1modelsget"></a>
# **GetOpenaiModelsOllamaV1ModelsGet**
> Object GetOpenaiModelsOllamaV1ModelsGet (int urlIdx = null)

Get Openai Models


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

<a id="getopenaimodelsollamav1modelsurlidxget"></a>
# **GetOpenaiModelsOllamaV1ModelsUrlIdxGet**
> Object GetOpenaiModelsOllamaV1ModelsUrlIdxGet (int urlIdx)

Get Openai Models


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

<a id="getstatusollamaget"></a>
# **GetStatusOllamaGet**
> Object GetStatusOllamaGet ()

Get Status


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getstatusollamahead"></a>
# **GetStatusOllamaHead**
> Object GetStatusOllamaHead ()

Get Status


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="pullmodelollamaapipullpost"></a>
# **PullModelOllamaApiPullPost**
> Object PullModelOllamaApiPullPost (ModelNameForm modelNameForm, int urlIdx = null)

Pull Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelNameForm** | [**ModelNameForm**](ModelNameForm.md) |  |  |
| **urlIdx** | **int** |  | [optional] [default to 0] |

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

<a id="pullmodelollamaapipullurlidxpost"></a>
# **PullModelOllamaApiPullUrlIdxPost**
> Object PullModelOllamaApiPullUrlIdxPost (int urlIdx, ModelNameForm modelNameForm)

Pull Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlIdx** | **int** |  |  |
| **modelNameForm** | [**ModelNameForm**](ModelNameForm.md) |  |  |

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

<a id="pushmodelollamaapipushdelete"></a>
# **PushModelOllamaApiPushDelete**
> Object PushModelOllamaApiPushDelete (PushModelForm pushModelForm, int urlIdx = null)

Push Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pushModelForm** | [**PushModelForm**](PushModelForm.md) |  |  |
| **urlIdx** | **int** |  | [optional]  |

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

<a id="pushmodelollamaapipushurlidxdelete"></a>
# **PushModelOllamaApiPushUrlIdxDelete**
> Object PushModelOllamaApiPushUrlIdxDelete (PushModelForm pushModelForm, int urlIdx)

Push Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pushModelForm** | [**PushModelForm**](PushModelForm.md) |  |  |
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

<a id="showmodelinfoollamaapishowpost"></a>
# **ShowModelInfoOllamaApiShowPost**
> Object ShowModelInfoOllamaApiShowPost (ModelNameForm modelNameForm)

Show Model Info


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelNameForm** | [**ModelNameForm**](ModelNameForm.md) |  |  |

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

<a id="unloadmodelollamaapiunloadpost"></a>
# **UnloadModelOllamaApiUnloadPost**
> Object UnloadModelOllamaApiUnloadPost (ModelNameForm modelNameForm)

Unload Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelNameForm** | [**ModelNameForm**](ModelNameForm.md) |  |  |

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

<a id="updateconfigollamaconfigupdatepost"></a>
# **UpdateConfigOllamaConfigUpdatePost**
> Object UpdateConfigOllamaConfigUpdatePost (OpenWebuiRoutersOllamaOllamaConfigForm openWebuiRoutersOllamaOllamaConfigForm)

Update Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **openWebuiRoutersOllamaOllamaConfigForm** | [**OpenWebuiRoutersOllamaOllamaConfigForm**](OpenWebuiRoutersOllamaOllamaConfigForm.md) |  |  |

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

<a id="uploadmodelollamamodelsuploadpost"></a>
# **UploadModelOllamaModelsUploadPost**
> Object UploadModelOllamaModelsUploadPost (System.IO.Stream file, int urlIdx = null)

Upload Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |
| **urlIdx** | **int** |  | [optional]  |

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

<a id="uploadmodelollamamodelsuploadurlidxpost"></a>
# **UploadModelOllamaModelsUploadUrlIdxPost**
> Object UploadModelOllamaModelsUploadUrlIdxPost (System.IO.Stream file, int urlIdx)

Upload Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |
| **urlIdx** | **int** |  |  |

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

<a id="verifyconnectionollamaverifypost"></a>
# **VerifyConnectionOllamaVerifyPost**
> Object VerifyConnectionOllamaVerifyPost (OpenWebuiRoutersOllamaConnectionVerificationForm openWebuiRoutersOllamaConnectionVerificationForm)

Verify Connection


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **openWebuiRoutersOllamaConnectionVerificationForm** | [**OpenWebuiRoutersOllamaConnectionVerificationForm**](OpenWebuiRoutersOllamaConnectionVerificationForm.md) |  |  |

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

