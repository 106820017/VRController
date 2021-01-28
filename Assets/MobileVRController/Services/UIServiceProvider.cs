using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UIServiceProvider : IServiceProvider
{
    public const string ServiceName = "UI";
    float _lightRange = 20;
    float _lightActive = 1;     //1 = true, 0 = false
    float _GUIDebug = 1;
    float _ShowModel = 1;
    Color _lightColor;
    //List<float> _lightInfo = new List<float>();
    List<byte> _data = new List<byte>();
    LightInfo _lightInfo = new LightInfo();

    public LightInfo Value
    {
        get
        {
            return _lightInfo;
        }
    }

    public UIServiceProvider (ServiceManager m) : base(m)
    {

    }

    public override string GetName()
    {
        return ServiceName;
    }

    public override bool IsReliable()
    {
        return false;
    }

    public override byte[] GetData()
    {
        return _data.ToArray();
    }

    public override void Update()
    {
        if (!_enabled || _mngr.IsReceiver)
            return;

        _lightInfo.range = _lightRange;
        _lightInfo.active = _lightActive;
        _lightInfo.r = _lightColor.r;
        _lightInfo.g = _lightColor.g;
        _lightInfo.b = _lightColor.b;
        _lightInfo.a = _lightColor.a;
        _lightInfo.debug = _GUIDebug;
        _lightInfo.model = _ShowModel;

        _data.Clear();
        //_lightInfo.Clear();

        //_lightInfo.Add(_lightRange);
        //_lightInfo.Add(_lightActive);
        _data.AddRange(BitConverter.GetBytes(_lightInfo.range));
        _data.AddRange(BitConverter.GetBytes(_lightInfo.active));
        _data.AddRange(BitConverter.GetBytes(_lightInfo.r));
        _data.AddRange(BitConverter.GetBytes(_lightInfo.g));
        _data.AddRange(BitConverter.GetBytes(_lightInfo.b));
        _data.AddRange(BitConverter.GetBytes(_lightInfo.a));
        _data.AddRange(BitConverter.GetBytes(_lightInfo.debug));
        _data.AddRange(BitConverter.GetBytes(_lightInfo.model));
        //Debug.Log(_data.ToString());

    }

    public void SetRange(float input)
    {
        _lightRange = input;
    }

    public void SetActive(bool active)
    {
        _lightActive = Convert.ToSingle(active);
    }

    public void SetColor(float r, float g, float b, float a)
    {
        _lightColor = new Color(r, g, b, a);
    }

    public void SetGUIDebug(bool active)
    {
        _GUIDebug = Convert.ToSingle(active);
    }

    public void ShowModel(bool active)
    {
        _ShowModel = Convert.ToSingle(active);
    }

    public override void ProcessData(byte[] data)
    {
        //Debug.Log(data);
        _lightInfo.range = BitConverter.ToSingle(data, 0);
        _lightInfo.active = BitConverter.ToSingle(data, 4);
        _lightInfo.r = BitConverter.ToSingle(data, 8);
        _lightInfo.g = BitConverter.ToSingle(data, 12);
        _lightInfo.b = BitConverter.ToSingle(data, 16);
        _lightInfo.a = BitConverter.ToSingle(data, 20);
        _lightInfo.debug = BitConverter.ToSingle(data, 24);
        _lightInfo.model = BitConverter.ToSingle(data, 28);
        //Debug.Log(BitConverter.GetBytes(_lightRange));
        //Debug.Log(_lightActive);

        if (OnValueChanged != null)
            OnValueChanged(this);
    }

    public override string GetDebugString()
    {
        return _lightInfo.active + " : " + _lightInfo.range + "RGBA (" + _lightInfo.r + ", " + _lightInfo.g + ", " + _lightInfo.b + ", " + _lightInfo.a + ") ";
    }
}
