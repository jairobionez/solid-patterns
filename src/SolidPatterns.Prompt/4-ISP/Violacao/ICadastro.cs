﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns.Prompt.ISP.Violacao
{
    public interface ICadastro
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}
