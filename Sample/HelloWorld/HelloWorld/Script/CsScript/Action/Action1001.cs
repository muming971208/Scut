/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/

using HelloWorld.Script.CsScript.Action;
using ZyGames.Framework.Game.Contract;

namespace GameServer.CsScript.Action
{
    /// <summary>
    /// 1001_hello������ɡ�
    /// </summary>
    public class Action1001 : BaseAction
    {
        private string content;


        public Action1001(HttpGet httpGet)
            : base(ActionIDDefine.Cst_Action1001, httpGet)
        {

        }

        public override void BuildPacket()
        {
            this.PushIntoStack(content);

        }

        public override bool GetUrlElement()
        {
            if (true)
            {
                return true;
            }
            return false;
        }

        public override bool TakeAction()
        {
            content = "Hello World!";
            return true;
        }
    }
}