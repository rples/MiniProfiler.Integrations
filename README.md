# MiniProfiler.Integrations
Provide custom IDbProfiler implemenation and some utility methods around MiniProfiler components

# Usage

### Initialize connection with the custom profiler

```
using (var connection = SqlConnectionFactory.New(connectionString, CustomDbProfiler.Current))
{
    // DO YOUR WORKS
}
```

### Get commands executed (Success / Fail)

```
string commands = CustomDbProfiler.Current.ProfilerContext.GetCommands()
```
