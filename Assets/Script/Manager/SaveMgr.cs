﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveMgr
{
    //맵 데이터 정보 이름 입니다
    public static class MapData
    {
        public const string mapNameDataName = "MapName";
        public const string mapSizeDataName = "MapSize";
        public const string mapSellDataName = "MapSell";
    }

    //데이터 분할 문자 입니다
    public static class DataEndSign
    {
        public const string endLine = "\n";
        public const string dataNameEnd = ":";
        public const string endData = "/";
    }


    //입력받은 경로의 파일에 입력받은 문자열을 입력합니다
    public static void WriteText(string path, string str)
    {
        string filePath = path;
        StreamWriter sw = null;

        if (!File.Exists(filePath))
        {
            sw = new StreamWriter(path + ".txt");
        }

        sw.WriteLine(str);

        sw.Flush();
        sw.Close();
    }


    //입력받은 경로의 파일의 내용을 읽어 반환합니다
    public static string ReadText(string path)
    {
        string str;
        StreamReader sr = null;

        if (!File.Exists(path))
        {
            sr = new StreamReader(path + ".txt");
        }

        str = sr.ReadToEnd();
        sr.Close();

        return str;
    }

    //입력받은 데이터들을 연결합니다
    public static string ConnectSaveData(params string[] datas)
    {
        string data = "";
        for(int i = 0; i < datas.Length; i++)
        {
            if (i == 0)
            {
                data += datas[i];
                continue;
            }

            data += DataEndSign.endLine + datas[i];
        }
        return data;
    }

    public static string ConnectData(string between, params string[] datas)
    {
        string data = "";
        for(int i = 0; i < datas.Length; i++)
        {
            if(i == 0)
            {
                data += datas[i];
                continue;
            }

            data += "\n" + datas[i];
        }

        return data;
    }
}
