using Python.Runtime;

Runtime.PythonDLL = Environment.CurrentDirectory.Replace("bin\\Debug\\net8.0", "venv\\python312.dll");
PythonEngine.Initialize();
