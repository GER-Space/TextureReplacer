/*
 * Copyright © 2014 Davorin Učakar
 *
 * Permission is hereby granted, free of charge, to any person obtaining a
 * copy of this software and associated documentation files (the "Software"),
 * to deal in the Software without restriction, including without limitation
 * the rights to use, copy, modify, merge, publish, distribute, sublicense,
 * and/or sell copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
 * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */

#if false
using System;
using System.Collections.Generic;
using UnityEngine;

namespace TextureReplacer
{
  internal class UI
  {
    private const int WINDOW_ID = 107056;
    private const Rect windowRect = new Rect(40, 40, 400, 400);
    // Instance.
    public static Replacer instance = null;

    private void draw()
    {
      GUILayout.Window(WINDOW_ID, windowRect, windowHandler, "TextureReplacer");
    }

    private void windowHandler(int id)
    {
      GUILayout.BeginVertical();

      foreach (ProtoCrewMember kerbal in HighLogic.CurrentGame.CrewRoster)
      {
        Color colour = new Color(1.0f, 0.0f, 0.0f);
        bool isChangeable = false;

        if (kerbal.rosterStatus == ProtoCrewMember.RosterStatus.AVAILABLE)
        {
          colour = new Color(1.0f, 1.0f, 1.0f);
          isChangeable = true;
        }
        else if (kerbal.rosterStatus == ProtoCrewMember.RosterStatus.ASSIGNED)
        {
          colour = new Color(1.0f, 1.0f, 0.0f);
        }
      }

      GUILayout.EndVertical();
    }
  }
}
#endif
