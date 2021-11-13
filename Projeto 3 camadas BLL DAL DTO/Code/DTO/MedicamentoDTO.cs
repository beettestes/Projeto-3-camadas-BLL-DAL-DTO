using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_3_camadas_BLL_DAL_DTO.Code.DTO
{
    class MedicamentoDTO
    {
        private int _id;
        private string _medicamento;
        private string _composicao;

public int Id { get => _id; set => _id = value; }
public string medicamento { get => _medicamento; set => _medicamento = value; }
public string composicao { get => _composicao; set => _composicao = value; }

    }
}
