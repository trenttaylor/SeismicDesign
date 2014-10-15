using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seismic_Design
{
  public class DigitalFilter
  {
    private double[] m_b = new double[2];
    private double[] m_a = new double[2];
    private double[] m_x;
    private double m_zi;
    private double[] m_y = new double[1024];
    private double[] m_zf = new double[1];

    public DigitalFilter(double[] b, double[] a, double[] x, double zi)
    {
      m_b = b;
      m_a = a;
      m_x = x;
      m_zi = zi;
    }

    private double[] getY()
    {
      calc();
      return m_y;
    }

    private double[] getZf()
    {
      calc();
      return m_zf;
    }

    private void calc()
    {

      for (int i = 0; i < m_y.Length; i++)
      {
        if (i == 0)
        {
          m_y[i] = m_b[0] * m_x[i] + m_zi;
        }

        else
        {
          m_y[i] = m_b[0] * m_x[i] + m_b[1] * m_x[i - 1] - m_a[1] * m_y[i - 1];

          if (i == m_x.Length - 1)
          {
            m_zf[0] = m_y[i];
          }
        }
      }
    }

    public double[] zeroFilter()
    {
      int len = m_x.Length;      // Length of input 
      int nb = m_b.Length;
      int na = m_a.Length;
      int nfilt = Math.Max(na, nb);
      int nfact = 3 * (nfilt - 1);    // Length of edge transients 

      // Computing the initial value 
      Double data = 1 + m_a[1];

      double zi;

      zi = (m_b[1] - m_a[1] * m_b[0]) / data;

      // Number of both Tim 

      double[] yTemp = new double[m_y.Length + 2 * nfact];

      for (int i = 0; i < nfact; i++)
      {
        yTemp[i] = 2 * m_x[0] - m_x[nfact - i];
      }

      for (int i = nfact; i < m_y.Length + nfact; i++)
      {
        yTemp[i] = m_x[i - nfact];
      }

      for (int i = m_y.Length + nfact; i < yTemp.Length; i++)
      {
        yTemp[i] = 2 * m_x[m_x.Length - 1] - m_x[yTemp.Length - 2 - i + m_y.Length - nfact];
      }

      // Forward filtering 
      m_zi = zi * yTemp[0];
      yTemp = zeroCalc(yTemp);

      // In reverse order 
      yTemp = this.reverse(yTemp);

      // Reverse filtering 
      m_zi = zi * yTemp[0];
      yTemp = zeroCalc(yTemp);

      // In reverse order 
      yTemp = this.reverse(yTemp);

      for (int i = 0; i < m_y.Length; i++)
      {
        m_y[i] = yTemp[i + nfact];
      }

      return m_y;
    }

    private double[] zeroCalc(double[] xx)
    {
      double[] yy = new double[xx.Length];

      for (int i = 0; i < yy.Length; i++)
      {
        if (i == 0)
        {
          yy[i] = m_b[0] * xx[i] + m_zi;
        }

        else
        {
          yy[i] = m_b[0] * xx[i] + m_b[1] * xx[i - 1] - m_a[1] * yy[i - 1];
        }

      }

      return yy;

    }

    private double[] reverse(double[] data)
    {
      double tmp;

      for (int i = 0; i < data.Length / 2; i++)
      {
        tmp = data[data.Length - i - 1];
        data[data.Length - i - 1] = data[i];
        data[i] = tmp;
      }

      return data;
    }
  }
}
