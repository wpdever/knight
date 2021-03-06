﻿//======================================================================
//        Copyright (C) 2015-2020 Winddy He. All rights reserved
//        Email: hgplan@126.com
//======================================================================
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Knight.Core;
using UnityEngine.UI;

namespace Knight.Framework.TinyMode.UI
{
    public class ScrollRectOnDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
    {
        public LoopScrollRect       ScrollRect;

        public Action<GameObject>   OnDragHandler;
        public Action<GameObject>   OnBeginDragHandler;
        public Action<GameObject>   OnEndDragHandler;

        public void OnDrag(PointerEventData eventData)
        {
            if (this.ScrollRect != null)
                this.ScrollRect.OnDrag(eventData);
            UtilTool.SafeExecute(OnDragHandler, this.gameObject);
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            if (this.ScrollRect != null)
                this.ScrollRect.OnBeginDrag(eventData);
            UtilTool.SafeExecute(OnBeginDragHandler, this.gameObject);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (this.ScrollRect != null)
                this.ScrollRect.OnEndDrag(eventData);
            UtilTool.SafeExecute(OnEndDragHandler, this.gameObject);
        }
    }
}
