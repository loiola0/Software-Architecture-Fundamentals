using NerdStore.Core.DomainObjects;
using System;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            // Arrange & Act & Assert

            var ex = Assert.Throws<DomainException>(() =>
                new Produto(string.Empty, "Descricao", false, Guid.NewGuid(), 100, DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo Nome do produto n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", string.Empty, false,Guid.NewGuid(), 100, DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo Descricao do produto n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descricao", false, Guid.NewGuid(), 0, DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo Valor do produto n�o pode se menor igual a 0", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descricao", false, Guid.Empty, 100, DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo CategoriaId do produto n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descricao", false, Guid.NewGuid(), 100, DateTime.Now, string.Empty, new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo Imagem do produto n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descricao", false, Guid.NewGuid(), 100, DateTime.Now, "Imagem", new Dimensoes(0, 1, 1))
            );

            Assert.Equal("O campo Altura n�o pode ser menor ou igual a 0", ex.Message);
        }
    }
}
