Biblioteca GeometriaSimples

Esta é uma DLL simples desenvolvida em C# para auxiliar no cálculo de áreas geométricas.

Como instalar no seu projeto
1. Baixe o arquivo `GeometriaSimples.dll` deste repositório.
2. No seu projeto do Visual Studio, clique com o botão direito em **Dependencies (Dependências)** > **Add Project Reference (Adicionar Referência)**.
3. Clique em **Browse (Procurar)**, selecione o arquivo `GeometriaSimples.dll` e clique em OK.

Como usar no código
Importe o namespace e instancie a classe `CalculadoraArea`:

```csharp
using GeometriaSimples;

CalculadoraArea calc = new CalculadoraArea();
double area = calc.Retangulo(5, 10); // Retorna 50
```
