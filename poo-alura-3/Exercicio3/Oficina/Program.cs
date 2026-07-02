Mecanico m1 = new Mecanico("Pedro");
Veiculo v1 = new Veiculo("Fiat", m1, "2005");
Cliente c1 = new Cliente("Joao", "3199312312", v1);

Oficina f1 = new Oficina("Avantgard");
f1.AgendarServico(m1, v1, c1, new DateTime(2026, 7, 1));
f1.RealizarServico(v1, m1, c1);
