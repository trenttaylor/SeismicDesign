using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seismic_Design
{
  public class PointD
  {
    private Double m_x;
    private Double m_y;

    public PointD(Double x, Double y)
    {
      m_x = x;
      m_y = y;
    }

    public Double X
    {
      get { return m_x; }
      set { m_x = X; }
    }

    public Double Y
    {
      get { return m_y; }
      set { m_y = Y; }
    }
  }
}
