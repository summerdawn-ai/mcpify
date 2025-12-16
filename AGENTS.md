# Agent Instructions

## Coding Style

All instructions in this section are for C# source code.

- DO use primary constructors for classes unless there is special initialization logic that cannot be done in a field initializer.
- DO NOT create private fields just to hold constructor arguments unless there's a specific need (e.g. `foo = foo..Validated()`).
- DO NOT add null checks to (constructor and other) arguments UNLESS the code is in reusable library in a public repository OR packaged and published as a NuGet package.
- DO use camelCase for private fields, no underscore prefix.

  So altogether, DO NOT this:
  
  ```
  public class CommandFactory
  {
      private readonly IAuthenticationService _authService;
      private readonly IVibeApiClient _apiClient;
  
      public CommandFactory(IAuthenticationService authService, IVibeApiClient apiClient)
      {
          _authService = authService ?? throw new ArgumentNullException(nameof(authService));
          _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
      }
  ```
  
  DO this:

  ```
  public class CommandFactory(IAuthenticationService authService, IVibeApiClient apiClient)
  ```
Coding style, continued
- DO use explicit access modifiers on all members, including private fields _and_ interface members.
- DO use explicit types, not `var`, for types with a C# keywrd: `bool`, `int`, `float`, `string`, `object` etc., including nullables e.g. `int?` or `string?`.
- DO use collection initializers whenever appropriate.
- Do NOT use full namespaces when referencing types, instead use `using` statements. There should not be any code like `[System.Text.Json.Serialization.JsonIgnore]`.
- DO NOT add unnecessary `using` statements. Depending on the project type, some projects (e.g. ASP.NET Core) will have default global usings - don't add those to individual files.

## Agentic working

- When you get a task, DO be diligent about it and do a build, run tests, get a code review etc. if appropriate.
- DO NOT, however, start making additional changes that are outside the scope of the task because of unrelated code review feedback or because
  the change inadvertently breaks all test cases. Instead, DO stop and ask for guidance, UNLESS you were explicitly instructed to keep going.
  The scope of your work should be proportional to the scope of the given task - if it grows, ask if that is intended.
