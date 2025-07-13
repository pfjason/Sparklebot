# SparkleBot Project Guide

## 1. Project Overview
SparkleBot is a unique Mastodon bot developed using .NET, designed to generate and post quirky, conversational content to a Mastodon account. The project originated from an unexpected and amusing AI conversation, which was then transformed into a systematic bot with a distinctive personality.

### Key Technologies
- .NET Core / .NET 8
- Blazor WebUI
- Mastodon API
- Dependency Injection
- Background Jobs
- Multiple Service Integrations (Mastodon, Gotify, LLM)

## 2. Getting Started

### Prerequisites
- .NET 8 SDK
- Docker (optional, for containerized deployment)
- Mastodon account credentials
- LLM service access (configuration required)

### Installation
1. Clone the repository
```bash
git clone https://github.com/your-repo/SparkleBot.git
cd SparkleBot
```

2. Configure Application
- Edit `SparkleBot/appsettings.json`
- Set up Mastodon, Gotify, and LLM service configurations

3. Running the Application
```bash
# Using .NET CLI
dotnet restore
dotnet build
dotnet run --project SparkleBot.WebUI

# Using Docker
docker-compose up --build
```

### Running Tests
*Note: No specific test project found. Add unit and integration tests.*
```bash
# Placeholder for future test command
dotnet test
```

## 3. Project Structure

### Main Directories
- `SparkleBot/`: Core application logic
  - `Services/`: Service implementations
  - `Models/`: Data models and configurations
  - `Interfaces/`: Service and job interfaces
  - `Jobs/`: Background job definitions
  - `DependencyInjection/`: Dependency injection setup

- `SparkleBot.WebUI/`: Web interface
  - `Components/`: Razor components
  - `wwwroot/`: Static web assets

### Key Configuration Files
- `appsettings.json`: Application configuration
- `SystemPrompt.txt`: Core bot personality definition
- `Dockerfile`: Containerization configuration
- `docker-compose.yml`: Multi-container deployment

## 4. Development Workflow

### Coding Standards
- Follow .NET and C# best practices
- Use dependency injection
- Implement interfaces for services
- Write clear, self-documenting code

### Contribution Guidelines
1. Fork the repository
2. Create a feature branch
3. Implement changes
4. Write/update tests
5. Ensure code passes all checks
6. Submit a pull request

### Building and Deployment
- Local development: `dotnet run`
- Docker deployment: `docker-compose up`
- Containerized builds use multi-stage Dockerfile

## 5. Key Concepts

### System Prompt
The bot's personality is defined in `SystemPrompt.txt`, which guides its conversational style and content generation.

### Service Architecture
- `MastodonService`: Handles Mastodon API interactions
- `LlmService`: Manages language model interactions
- `JournalService`: Handles conversation and content logging
- `GotifyService`: Manages notifications

### Jobs
- `DailyPostJob`: Scheduled content generation and posting

## 6. Common Tasks

### Adding a New Service
1. Create an interface in `Interfaces/`
2. Implement the service in `Services/`
3. Register in `DependencyInjection/RootScopeModule.cs`

### Modifying Bot Personality
Edit `SystemPrompt.txt` to adjust the bot's conversational style and content generation parameters.

## 7. Troubleshooting

### Common Issues
- Credential configuration problems
- API rate limiting
- Service connectivity issues

### Debugging Tips
- Check `appsettings.json` configurations
- Verify API credentials
- Use logging for service interactions
- Monitor background job execution

### Style Rules
 - Log OR throw, never log AND throw.

## 8. References
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [Mastodon API](https://docs.joinmastodon.org/api/)
- [Blazor Guide](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)

## 9. Future Improvements
- Implement comprehensive test suite
- Add more interactive features
- Enhance error handling and logging
- Expand service integrations

---

*This guide is automatically loaded by Continue for context. Please update and maintain it as the project evolves.*