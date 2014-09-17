using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Cordova.Extension.Commands
{
    public class Pedometer : BaseCommand
    {
                                
        public void init(string options)
        {
            try
            {                
                DispatchCommandResult(new PluginResult(PluginResult.Status.OK, ""));
            }
            catch (Exception ex)
            {
                DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR, new { error = "close", message = ex.Message }));
            }
        }

        public void start(string options)
        {
            try
            {
                DispatchCommandResult(new PluginResult(PluginResult.Status.OK, ""));
            }
            catch (Exception ex)
            {
                DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR, new { error = "close", message = ex.Message }));
            }
        }

        public void stop(string options)
        {
            try
            {
                DispatchCommandResult(new PluginResult(PluginResult.Status.OK, ""));
            }
            catch (Exception ex)
            {
                DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR, new { error = "close", message = ex.Message }));
            }
        }
           
        private JObject Parse(string options)
        {
            string opt = JsonHelper.Deserialize<string[]>(options)[0];
            return JObject.Parse(opt);
        }

        private T Parse<T>(string options)
        {
            string opt = JsonHelper.Deserialize<string[]>(options)[0];
            return !String.IsNullOrEmpty(opt) ? JsonConvert.DeserializeObject<T>(opt) : default(T);
        }
    }
}
