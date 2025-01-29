const produtos = [
    {
        breads: [
            {
                imagem: 'https://picsum.photos/500?random=1',
                nome: 'Pão Francês',
                preco: 1.50,
                medida: 'unidade',
                descricao: 'O tradicional pão francês, fresquinho, crocante por fora e macio por dentro. Ideal para o café da manhã.'
            },
            {
                imagem: 'https://picsum.photos/500?random=2',
                nome: 'Pão de Queijo',
                preco: 4.00,
                medida: 'unidade',
                descricao: 'Pão de queijo quentinho e irresistível, feito com queijo minas e polvilho, perfeito para o café da manhã ou lanche da tarde.'
            },
            {
                imagem: 'https://picsum.photos/500?random=3',
                nome: 'Pão de Forma',
                preco: 6.90,
                medida: 'fatia',
                descricao: 'Pão macio, ideal para sanduíches, disponível em versões integral e branco.'
            },
            {
                imagem: 'https://picsum.photos/500?random=4',
                nome: 'Pão Ciabatta',
                preco: 7.00,
                medida: 'unidade',
                descricao: 'Pão italiano com crosta crocante e miolo aerado, perfeito para acompanhar uma refeição.'
            }
        ],
        savories: [
            {
                imagem: 'https://picsum.photos/500?random=5',
                nome: 'Coxinha de Frango',
                preco: 6.00,
                medida: 'unidade',
                descricao: 'Massa crocante com recheio generoso de frango desfiado e temperado com carinho.'
            },
            {
                imagem: 'https://picsum.photos/500?random=6',
                nome: 'Empada de Palmito',
                preco: 5.50,
                medida: 'unidade',
                descricao: 'Massa amanteigada recheada com palmito refogado, uma verdadeira delícia.'
            },
            {
                imagem: 'https://picsum.photos/500?random=7',
                nome: 'Pastel de Queijo',
                preco: 7.00,
                medida: 'unidade',
                descricao: 'Pastel de massa crocante, recheado com queijo muçarela derretido.'
            },
            {
                imagem: 'https://picsum.photos/500?random=8',
                nome: 'Esfiha de Carne',
                preco: 4.50,
                medida: 'unidade',
                descricao: 'Massa leve e saborosa, recheada com carne temperada e cebola.'
            }
        ],
        sweets: [
            {
                imagem: 'https://picsum.photos/500?random=9',
                nome: 'Bolo de Cenoura com Chocolate',
                preco: 5.00,
                medida: 'fatia',
                descricao: 'Bolo fofinho de cenoura com cobertura cremosa de chocolate e granulado por cima.'
            },
            {
                imagem: 'https://picsum.photos/500?random=10',
                nome: 'Brigadeiro',
                preco: 3.00,
                medida: 'unidade',
                descricao: 'O tradicional docinho de brigadeiro feito com leite condensado, chocolate e granulado.'
            },
            {
                imagem: 'https://picsum.photos/500?random=11',
                nome: 'Torta de Limão',
                preco: 6.50,
                medida: 'fatia',
                descricao: 'Torta de base crocante, recheio cremoso de limão e cobertura de merengue, um clássico irresistível.'
            },
            {
                imagem: 'https://picsum.photos/500?random=12',
                nome: 'Churros',
                preco: 4.00,
                medida: 'unidade',
                descricao: 'Massa crocante com recheio de doce de leite, polvilhado com açúcar e canela.'
            }
        ],
        drinks: [
            {
                imagem: 'https://picsum.photos/500?random=13',
                nome: 'Café Expresso',
                preco: 3.00,
                medida: '50ml',
                descricao: 'Café forte e encorpado, ideal para acompanhar qualquer um de nossos pães.'
            },
            {
                imagem: 'https://picsum.photos/500?random=14',
                nome: 'Café com Leite',
                preco: 3.00,
                medida: '80ml',
                descricao: 'Café suave combinado com leite cremoso, ideal para um lanche da tarde.'
            },
            {
                imagem: 'https://picsum.photos/500?random=15',
                nome: 'Suco Natural (laranja, maracujá ou abacaxi)',
                preco: 5.00,
                medida: '200ml',
                descricao: 'Suco fresco, feito com frutas selecionadas e espremido na hora.'
            },
            {
                imagem: 'https://picsum.photos/500?random=16',
                nome: 'Chá Gelado (limão ou pêssego)',
                preco: 4.50,
                medida: '200ml',
                descricao: 'Chá gelado refrescante, ideal para os dias quentes.'
            }
        ]
    }
];

function renderizarProdutos(categoria) {
    const container = document.getElementById(categoria);
    if (!container) return;

    let categorias = produtos[0];

    let produtosFiltrados = categoria === 'all'
        ? Object.values(categorias).flat()
        : categorias[categoria] || [];

    container.innerHTML = produtosFiltrados.length
        ? produtosFiltrados.map(produto => `
            <div class="d-flex align-items-center mb-4">
                <div class="flex-shrink-0">
                    <img src="${produto.imagem}" alt="${produto.nome}" width="150px">
                </div>
                <div class="flex-grow-1 ms-3">
                    <h5>${produto.nome}</h5>
                    <p style="font-size: 110%">R$ ${produto.preco.toFixed(2)} <span style="font-size: 85%">(${produto.medida})</span></p>
                    <p>${produto.descricao}</p>
                </div>
            </div>
        `).join("")
        : "<p class='text-center'>Nenhum produto disponível.</p>";
}

document.addEventListener("DOMContentLoaded", () => {
    renderizarProdutos("all");
    renderizarProdutos("breads");
    renderizarProdutos("savories");
    renderizarProdutos("sweets");
    renderizarProdutos("snacks");
    renderizarProdutos("drinks");
});