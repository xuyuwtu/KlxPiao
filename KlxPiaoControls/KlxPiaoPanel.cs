﻿using KlxPiaoAPI;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace KlxPiaoControls
{
    /// <summary>
    /// 表示一个具有自定义外观和投影效果的面板控件。
    /// </summary>
    /// <remarks>
    /// KlxPiaoPanel 继承自 <see cref="Panel"/> 类，可以设置边框样式、圆角大小、投影效果等外观属性。
    /// </remarks>
    [DefaultEvent("Click")]
    public partial class KlxPiaoPanel : Panel
    {
        public enum 方向
        {
            右下,
            左下,
            左下右
        }
        private Color _边框颜色;
        private Color _边框外部颜色;
        private int _边框大小;
        private CornerRadius _圆角大小;
        private bool _启用投影;
        private int _投影长度;
        private Color _投影颜色;
        private 方向 _投影方向;

        public KlxPiaoPanel()
        {
            InitializeComponent();

            _边框颜色 = Color.FromArgb(199, 199, 199);
            _边框外部颜色 = Color.White;
            _边框大小 = 1;
            _启用投影 = true;
            _投影长度 = 5;
            _投影颜色 = Color.FromArgb(142, 142, 142);
            _投影方向 = 方向.右下;
            _圆角大小 = new CornerRadius(0);

            BackColor = Color.White;
            BorderStyle = BorderStyle.None;
            Size = new Size(100, 100);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        #region KlxPiaoPanel外观
        [Category("KlxPiaoPanel外观")]
        [Description("边框的颜色")]
        [DefaultValue(typeof(Color), "199,199,199")]
        public Color 边框颜色
        {
            get { return _边框颜色; }
            set { _边框颜色 = value; Invalidate(); }
        }
        [Category("KlxPiaoPanel外观")]
        [Description("边框外部的颜色，启用阴影时失效")]
        [DefaultValue(typeof(Color), "White")]
        public Color 边框外部颜色
        {
            get { return _边框外部颜色; }
            set { _边框外部颜色 = value; Invalidate(); }
        }
        [Category("KlxPiaoPanel外观")]
        [Description("边框的大小，启用阴影时失效")]
        [DefaultValue(1)]
        public int 边框大小
        {
            get { return _边框大小; }
            set { _边框大小 = value; Invalidate(); }
        }
        [Category("KlxPiaoPanel外观")]
        [Description("每个角的圆角大小，自动检测是百分比大小还是像素大小。")]
        [DefaultValue(typeof(CornerRadius), "0,0,0,0")]
        public CornerRadius 圆角大小
        {
            get { return _圆角大小; }
            set { _圆角大小 = value; Invalidate(); }
        }
        [Category("KlxPiaoPanel外观")]
        [Description("是否启用投影")]
        [DefaultValue(true)]
        public bool 启用投影
        {
            get { return _启用投影; }
            set { _启用投影 = value; Invalidate(); }
        }
        [Category("KlxPiaoPanel外观")]
        [Description("投影的长度")]
        [DefaultValue(5)]
        public int 投影长度
        {
            get { return _投影长度; }
            set { _投影长度 = value; Invalidate(); }
        }
        [Category("KlxPiaoPanel外观")]
        [Description("投影的颜色，减淡到白色")]
        [DefaultValue(typeof(Color), "142,142,142")]
        public Color 投影颜色
        {
            get { return _投影颜色; }
            set { _投影颜色 = value; Invalidate(); }
        }
        [Category("KlxPiaoPanel外观")]
        [Description("投影的方向")]
        [DefaultValue(typeof(方向), "右下")]
        public 方向 投影方向
        {
            get { return _投影方向; }
            set { _投影方向 = value; Invalidate(); }
        }
        #endregion

        [DefaultValue(typeof(Size), "100,100")]
        public new Size Size
        {
            get { return base.Size; }
            set { base.Size = value; Invalidate(); }
        }
        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            using Bitmap bitmap = new(Width, Height);
            {
                Graphics g = Graphics.FromImage(bitmap);
                g.Clear(Color.White);

                int 递减R = (255 - 投影颜色.R) / 投影长度;
                int 递减G = (255 - 投影颜色.G) / 投影长度;
                int 递减B = (255 - 投影颜色.B) / 投影长度;

                int 递减值 = 255 / 投影长度;

                if (启用投影)
                {
                    Rectangle 边框Rect = Rectangle.Empty;
                    Rectangle 背景Rect = Rectangle.Empty;

                    switch (投影方向)
                    {
                        case 方向.右下:
                            边框Rect = new Rectangle(0, 0, Width - 投影长度 - 1, Height - 投影长度 - 1);
                            背景Rect = new Rectangle(1, 1, Width - 投影长度 - 2, Height - 投影长度 - 2);

                            for (int i = 0; i <= 投影长度; i++)
                            {
                                SolidBrush brush = new(Color.FromArgb(递减值, 255 - i * 递减R, 255 - i * 递减G, 255 - i * 递减B));
                                g.FillRectangle(brush, new Rectangle(投影长度 - i, 投影长度 - i, Width - 投影长度, Height - 投影长度));
                            }
                            break;
                        case 方向.左下:
                            边框Rect = new Rectangle(投影长度, 0, Width - 投影长度 - 1, Height - 投影长度 - 1);
                            背景Rect = new Rectangle(投影长度 + 1, 1, Width - 投影长度 - 2, Height - 投影长度 - 2);

                            for (int i = 0; i <= 投影长度; i++)
                            {
                                SolidBrush brush = new(Color.FromArgb(递减值, 255 - i * 递减R, 255 - i * 递减G, 255 - i * 递减B));
                                g.FillRectangle(brush, new Rectangle(i, 投影长度 - i, Width - 投影长度, Height - 投影长度));
                            }
                            break;
                        case 方向.左下右:
                            边框Rect = new Rectangle(投影长度, 0, Width - 投影长度 * 2 - 1, Height - 投影长度 - 1);
                            背景Rect = new Rectangle(投影长度 + 1, 1, Width - 投影长度 * 2 - 2, Height - 投影长度 - 2);

                            for (int i = 0; i <= 投影长度; i++)
                            {
                                SolidBrush brush = new(Color.FromArgb(递减值, 255 - i * 递减R, 255 - i * 递减G, 255 - i * 递减B));
                                g.FillRectangle(brush, new Rectangle(投影长度 * 2 - i, 投影长度 - i, Width - 投影长度 * 2, Height - 投影长度));
                                g.FillRectangle(brush, new Rectangle(i, 投影长度 - i, Width - 投影长度 * 2, Height - 投影长度));

                            }
                            break;
                    }
                    //边框
                    using Pen borderPen = new(边框颜色, 1);
                    {
                        g.DrawRectangle(borderPen, 边框Rect);
                    }
                    //背景
                    using SolidBrush backBrush = new(BackColor);
                    {
                        g.FillRectangle(backBrush, 背景Rect);
                    }
                }
                else //不启用投影
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    // 背景
                    using (SolidBrush brush = new(BackColor))
                    {
                        g.FillRectangle(brush, new Rectangle(0, 0, Width, Height));
                    }

                    Rectangle 区域 = new(0, 0, Width, Height);

                    g.绘制圆角(区域, 圆角大小, 边框外部颜色, new Pen(边框颜色, 边框大小));
                }
                pe.Graphics.DrawImage(bitmap, 0, 0);
            }

            base.OnPaint(pe);
        }
        /// <summary>
        /// 获取工作区的大小
        /// </summary>
        /// <returns></returns>
        public Size 获取工作区大小()
        {
            if (启用投影)
            {
                if (投影方向 == 方向.左下右)
                {
                    return new Size(Width - 投影长度 * 2, Height - 投影长度);
                }
                else
                {
                    return new Size(Width - 投影长度, Height - 投影长度);
                }
            }
            else
            {
                return new Size(Width - 边框大小 * 2, Height - 边框大小 * 2);
            }
        }
        /// <summary>
        /// 获取工作区的大小
        /// </summary>
        /// <returns></returns>
        public Rectangle 获取工作区矩形()
        {
            if (启用投影)
            {
                if (投影方向 == 方向.右下)
                {
                    return new Rectangle(new Point(0, 0), 获取工作区大小());
                }
                else
                {
                    return new Rectangle(new Point(投影长度, 0), 获取工作区大小());
                }
            }
            else
            {
                return new Rectangle(new Point(边框大小, 边框大小), 获取工作区大小());
            }
        }
    }
}