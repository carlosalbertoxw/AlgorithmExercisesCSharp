# AlgorithmExercisesCSharp

Este repositorio contiene una colección de ejercicios de algoritmos resueltos en C#. Está diseñado para practicar lógica de programación, estructuras de datos y técnicas de resolución de problemas. Cada ejercicio incluye su solución documentada (con enlace al problema original y análisis de complejidad) y sus pruebas unitarias en xUnit v3.

## Ejercicios

| Categoría | Ejercicio | Problema | Enfoque | Complejidad | Solución | Tests |
|---|---|---|---|---|---|---|
| Arrays & Hashing | Two Sum | [LeetCode 1](https://leetcode.com/problems/two-sum/) | Diccionario en una pasada | O(n) | [TwoSum.cs](src/AlgorithmExercises/ArraysHashing/TwoSum/TwoSum.cs) | [TwoSumTests.cs](tests/AlgorithmExercises.Tests/ArraysHashing/TwoSumTests.cs) |
| Two Pointers | Two Sum Less Than K | [LeetCode 1099](https://leetcode.com/problems/two-sum-less-than-k/) | Fuerza bruta y dos punteros | O(n²) / O(n log n) | [TwoSumLessThanK.cs](src/AlgorithmExercises/TwoPointers/TwoSumLessThanK/TwoSumLessThanK.cs) | [TwoSumLessThanKTests.cs](tests/AlgorithmExercises.Tests/TwoPointers/TwoSumLessThanKTests.cs) |
| Stacks | Valid Parentheses | [LeetCode 20](https://leetcode.com/problems/valid-parentheses/) | Pila | O(n) | [ValidParentheses.cs](src/AlgorithmExercises/Stacks/ValidParentheses/ValidParentheses.cs) | [ValidParenthesesTests.cs](tests/AlgorithmExercises.Tests/Stacks/ValidParenthesesTests.cs) |
| Stacks | Baseball Game | [LeetCode 682](https://leetcode.com/problems/baseball-game/) | Lista como pila | O(n) | [BaseballGame.cs](src/AlgorithmExercises/Stacks/BaseballGame/BaseballGame.cs) | [BaseballGameTests.cs](tests/AlgorithmExercises.Tests/Stacks/BaseballGameTests.cs) |

## Estructura del proyecto

Las soluciones se agrupan por categoría (siguiendo los temas de [NeetCode](https://neetcode.io/roadmap)), y `tests/` espeja la estructura de `src/`:

```
├── src/
│   └── AlgorithmExercises/            # Biblioteca con las soluciones
│       ├── ArraysHashing/
│       │   └── TwoSum/
│       ├── TwoPointers/
│       │   └── TwoSumLessThanK/
│       └── Stacks/
│           ├── BaseballGame/
│           └── ValidParentheses/
├── tests/
│   └── AlgorithmExercises.Tests/      # Pruebas unitarias con xUnit v3 (espejo de src/)
│       ├── ArraysHashing/
│       ├── TwoPointers/
│       └── Stacks/
├── .github/
│   ├── workflows/ci.yml               # CI: compila y ejecuta los tests en cada push/PR
│   └── dependabot.yml                 # Actualizaciones automáticas de dependencias
├── global.json                        # Usa Microsoft.Testing.Platform para `dotnet test`
└── AlgorithmExercisesCSharp.slnx
```

Convención de nombres: la clase de cada solución se llama `Solution` dentro del namespace del ejercicio (p. ej. `AlgorithmExercises.ArraysHashing.TwoSum.Solution`). Si un ejercicio tiene varias implementaciones, cada clase se nombra por su enfoque (p. ej. `BruteForceSolution`, `TwoPointersSolution`). Los métodos son de instancia, como en LeetCode.

## Requisitos

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) o superior

## Uso

```bash
# Compilar la solución
dotnet build

# Ejecutar todas las pruebas
dotnet test

# Ejecutar las pruebas de un ejercicio concreto
dotnet test --filter-class "*TwoSumTests"
```

## Agregar un nuevo ejercicio

1. Elige la categoría (o crea una nueva, p. ej. `SlidingWindow/`, `LinkedLists/`, `DynamicProgramming/`) y crea la carpeta `src/AlgorithmExercises/<Categoría>/<NombreDelEjercicio>/` con la clase `Solution`, usando el namespace `AlgorithmExercises.<Categoría>.<NombreDelEjercicio>`.
2. Documenta la clase con un comentario XML que incluya el enlace al problema y la complejidad.
3. Agrega sus pruebas en `tests/AlgorithmExercises.Tests/<Categoría>/<NombreDelEjercicio>Tests.cs`, espejando la ruta de la solución. Nombra los métodos de prueba como `Metodo_ResultadoEsperado_Condicion` y usa `[Theory]` para agrupar casos.
4. Añade la fila correspondiente a la tabla de ejercicios de este README.

## Licencia

[MIT](LICENSE)
