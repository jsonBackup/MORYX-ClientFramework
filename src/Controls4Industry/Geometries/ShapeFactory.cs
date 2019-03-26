﻿using System.Collections.Generic;
using System.Windows.Media;

namespace C4I
{
    /// <summary>
    /// Factory that creates all <see cref="CommonShapeType"/> icons
    /// </summary>
    public static class ShapeFactory
    {
        private static readonly Dictionary<CommonShapeType, string> CommonGeometries = new Dictionary<CommonShapeType, string>();

        static ShapeFactory()
        {
            CommonGeometries.Add(CommonShapeType.ArrowRight, "F1M0.112,0.678C0.112,0.678 0.112,32.929 0.112,32.929 0.112,32.929 26.719,16.803 26.719,16.803 26.719,16.803 0.112,0.678 0.112,0.678z");
            CommonGeometries.Add(CommonShapeType.ArrowLeft, "F1M27.01,0.678C27.01,0.678 0.403,16.803 0.403,16.803 0.403,16.803 27.01,32.929 27.01,32.929 27.01,32.929 27.01,0.678 27.01,0.678z");
            CommonGeometries.Add(CommonShapeType.CheckMark, "F1M19.643,1.992C19.643,1.532 19.589,1.203 19.479,1.008 19.37,0.813 19.186,0.715 18.928,0.715 18.585,0.715 18.167,0.875 17.675,1.196 17.182,1.516 16.624,1.989 15.999,2.614 15.999,2.614 8.557,9.985 8.557,9.985 8.112,10.422 7.729,10.768 7.409,11.022 7.089,11.276 6.87,11.403 6.753,11.403 6.471,11.403 6.249,11.188 6.085,10.758 5.921,10.328 5.776,9.571 5.651,8.485 5.643,8.407 5.632,8.285 5.616,8.121 5.467,6.707 5.007,6 4.233,6 3.421,6 2.678,6.342 2.007,7.026 1.335,7.709 0.999,8.453 0.999,9.258 0.999,10.735 1.075,12.106 1.227,13.371 1.38,14.637 1.542,15.465 1.714,15.856 1.917,16.324 2.366,16.78 3.061,17.221 3.757,17.662 4.339,17.883 4.807,17.883 5.253,17.883 6.016,17.442 7.098,16.559 8.18,15.676 9.491,14.426 11.03,12.809 11.03,12.809 18.272,5.18 18.272,5.18 18.272,5.18 18.401,5.051 18.401,5.051 19.229,4.184 19.643,3.293 19.643,2.379 19.643,2.379 19.643,1.992 19.643,1.992z");
            CommonGeometries.Add(CommonShapeType.Info, "");
            CommonGeometries.Add(CommonShapeType.AttentionTriangle, "F1M88.637,69.582C88.637,69.582 51.014,4.166 51.014,4.166 49.738,1.946 47.547,0.602 45.208,0.602 42.868,0.602 40.677,1.946 39.401,4.166 39.401,4.166 1.778,69.582 1.778,69.582 0.391,71.993 0.282,75.07 1.494,77.6 2.705,80.13 5.043,81.705 7.585,81.705 7.585,81.705 82.83,81.705 82.83,81.705 85.372,81.705 87.71,80.13 88.922,77.6 90.134,75.07 90.024,71.993 88.637,69.582z");
            CommonGeometries.Add(CommonShapeType.Cross, "F1M75.124,8.381C75.124,8.381 72.756,8.381 72.756,8.381 72.35,8.138 71.986,7.856 71.662,7.531 71.338,7.207 71.055,6.823 70.812,6.377 70.812,6.377 71.541,4.919 71.541,4.919 70.973,3.908 70.285,3.036 69.476,2.308 68.665,1.579 67.734,0.992 66.682,0.546 61.539,5.082 56.508,9.83 51.589,14.789 46.669,19.75 41.84,24.943 37.103,30.368 35.038,27.372 32.426,23.424 29.268,18.524 24.57,11.236 21.453,7.066 19.914,6.013 19.914,6.013 17.545,6.62 17.545,6.62 17.181,7.025 16.928,7.481 16.786,7.987 16.644,8.493 16.574,9.09 16.574,9.778 16.29,10.021 15.997,10.244 15.693,10.446 15.389,10.65 15.055,10.832 14.691,10.993 14.366,10.669 14.032,10.366 13.689,10.082 13.344,9.799 12.808,9.394 12.079,8.867 11.269,9.515 10.509,10.234 9.801,11.023 9.092,11.813 8.435,12.674 7.827,13.605 9.65,19.476 11.745,25.186 14.114,30.733 16.482,36.281 19.164,41.726 22.161,47.071 18.112,51.647 14.286,56.051 10.682,60.281 7.078,64.513 3.656,68.633 0.417,72.641 0.7,73.452 1.095,74.403 1.602,75.496 2.108,76.589 2.361,77.318 2.361,77.683 2.361,77.804 2.158,78.26 1.754,79.049 1.348,79.839 1.025,80.558 0.782,81.205 1.308,82.461 1.976,83.625 2.786,84.698 3.596,85.771 4.527,86.753 5.58,87.644 6.309,87.199 6.876,86.895 7.281,86.733 7.685,86.571 8.07,86.45 8.435,86.368 8.435,86.368 9.224,86.975 9.224,86.975 9.224,86.975 8.738,88.98 8.738,88.98 8.738,88.98 11.047,91.713 11.047,91.713 11.047,91.713 12.929,91.592 12.929,91.592 15.885,87.502 19.023,83.291 22.344,78.958 25.663,74.626 29.247,70.051 33.094,65.232 35.281,68.714 37.518,72.045 39.806,75.223 42.093,78.402 44.452,81.409 46.882,84.242 46.882,84.242 48.521,84.485 48.521,84.485 49.372,83.96 50.151,83.362 50.86,82.694 51.568,82.025 52.166,81.307 52.652,80.537 53.299,81.145 53.947,81.652 54.595,82.056 55.242,82.461 55.871,82.785 56.478,83.028 56.882,82.663 57.45,82.177 58.179,81.57 58.908,80.962 59.413,80.537 59.697,80.294 59.697,80.294 59.697,80.051 59.697,80.051 59.697,79.404 59.828,78.776 60.092,78.169 60.355,77.561 60.709,77.035 61.155,76.589 62.329,76.428 63.32,75.821 64.131,74.767 64.94,73.715 65.71,72.034 66.439,69.726 63.24,65.921 60.122,62.084 57.085,58.216 54.049,54.35 51.072,50.472 48.157,46.585 52.327,41.16 56.7,35.856 61.276,30.672 65.852,25.489 70.63,20.428 75.61,15.488 75.61,15.488 75.793,14.698 75.793,14.698 76.157,14.253 76.491,13.787 76.795,13.301 77.098,12.815 77.372,12.289 77.615,11.722 77.615,11.722 75.124,8.381 75.124,8.381z");
            CommonGeometries.Add(CommonShapeType.ExclamationMark, "F1M0.357,38.008C0.357,38.008 12.588,38.008 12.588,38.008 12.588,38.008 12.588,46 12.588,46 12.588,46 0.357,46 0.357,46 0.357,46 0.357,38.008 0.357,38.008z M0.146,0.923C0.146,0.923 12.8,0.923 12.8,0.923 12.8,0.923 11.407,33.013 11.407,33.013 11.407,33.013 1.538,33.013 1.538,33.013 1.538,33.013 0.146,0.923 0.146,0.923z");
            CommonGeometries.Add(CommonShapeType.FullScreen, "");
            CommonGeometries.Add(CommonShapeType.Lock, "F1M5.568,7.422C5.035,7.422 4.604,7.854 4.604,8.385 4.604,8.702 4.758,8.983 4.993,9.159 4.993,9.159 4.993,10.327 4.993,10.327 4.993,10.644 5.249,10.901 5.568,10.901 5.884,10.901 6.141,10.644 6.141,10.327 6.141,10.327 6.141,9.159 6.141,9.159 6.376,8.983 6.53,8.702 6.53,8.385 6.53,7.854 6.098,7.422 5.568,7.422z M2.099,5.641C2.099,5.641 9.036,5.641 9.036,5.641 9.788,5.641 10.397,6.251 10.397,7.002 10.397,7.002 10.397,11.262 10.397,11.262 10.397,12.013 9.788,12.623 9.036,12.623 9.036,12.623 2.099,12.623 2.099,12.623 1.346,12.623 0.737,12.013 0.737,11.262 0.737,11.262 0.737,7.002 0.737,7.002 0.737,6.251 1.346,5.641 2.099,5.641z M5.568,0.195C7.455,0.195 8.991,1.731 8.991,3.618 8.991,3.618 8.991,5.131 8.991,5.131 8.991,5.131 7.455,5.131 7.455,5.131 7.455,5.131 7.455,3.618 7.455,3.618 7.455,2.577 6.608,1.731 5.568,1.731 4.527,1.731 3.68,2.577 3.68,3.618 3.68,3.618 3.68,5.131 3.68,5.131 3.68,5.131 2.143,5.131 2.143,5.131 2.143,5.131 2.143,3.618 2.143,3.618 2.143,1.731 3.68,0.195 5.568,0.195z");
            CommonGeometries.Add(CommonShapeType.Magnifier, "F1M7,3.304C4.515,3.304 2.5,5.319 2.5,7.804 2.5,10.29 4.515,12.304 7,12.304 9.485,12.304 11.5,10.29 11.5,7.804 11.5,5.319 9.485,3.304 7,3.304z M7,0.8C10.866,0.8 14,3.934 14,7.8 14,9.231 13.567,10.558 12.83,11.667 12.83,11.667 16.761,15.598 16.761,15.598 16.761,15.598 14.499,17.861 14.499,17.861 14.499,17.861 10.479,13.841 10.479,13.841 9.45,14.434 8.273,14.8 7,14.8 3.134,14.8 0,11.666 0,7.8 0,3.934 3.134,0.8 7,0.8z");
            CommonGeometries.Add(CommonShapeType.Pencil, "F1M1.171,11.828C1.656,12.016 2.111,12.499 2.338,12.954 2.119,13.022 1.901,13.091 1.682,13.159 0.736,13.34 0.973,12.285 1.171,11.828z M3.014,9.063C3.157,9.063 3.3,9.063 3.444,9.063 3.532,9.514 3.621,9.964 3.71,10.415 4.195,10.517 4.679,10.62 5.164,10.722 5.184,11.166 5.205,11.609 5.225,12.053 4.502,12.278 3.778,12.504 3.055,12.729 2.743,12.085 2.124,11.342 1.416,11.111 1.642,10.442 1.867,9.773 2.092,9.104 2.399,9.09 2.706,9.077 3.014,9.063z M13.048,3.411C13.151,3.526 13.281,4.001 13.192,4.21 10.782,6.626 8.372,9.043 5.963,11.459 5.956,11.459 5.949,11.459 5.942,11.459 5.922,11.159 5.901,10.858 5.881,10.558 8.27,8.176 10.659,5.793 13.048,3.411z M11.389,1.527C11.819,1.916 12.25,2.305 12.68,2.694 11.84,3.534 11,4.374 10.161,5.213 8.57,6.81 6.98,8.408 5.389,10.005 5.143,9.976 4.496,9.899 4.345,9.739 4.27,9.425 4.195,9.111 4.12,8.797 6.543,6.374 8.966,3.95 11.389,1.527z M9.895,0.994C10.142,1.005 10.497,1.068 10.673,1.179 8.311,3.547 5.949,5.916 3.587,8.285 3.58,8.285 3.573,8.285 3.567,8.285 3.232,8.305 2.898,8.326 2.563,8.346 5.007,5.896 7.451,3.445 9.895,0.994z");
            CommonGeometries.Add(CommonShapeType.PxCLogo, "F1M88.978,19.7C88.978,19.7 87.942,23.025 87.942,23.025 87.942,23.025 90.016,23.025 90.016,23.025 90.016,23.025 88.978,19.7 88.978,19.7z M48.256,18.957C46.795,18.964 45.944,20.456 45.961,21.916 45.978,23.355 46.819,24.8 48.259,24.804 49.702,24.809 50.555,23.36 50.572,21.916 50.59,20.451 49.722,18.95 48.256,18.957z M71.916,15.172C71.916,15.172 83.393,15.172 83.393,15.172 83.393,15.172 83.393,18.721 83.393,18.721 83.393,18.721 80.104,18.723 80.104,18.723 80.104,18.723 80.104,28.531 80.104,28.531 80.104,28.531 75.296,28.531 75.296,28.531 75.296,28.531 75.297,18.722 75.297,18.722 75.297,18.722 71.916,18.725 71.916,18.725 71.916,18.725 71.916,15.172 71.916,15.172z M116.259,15.171C116.259,15.171 116.259,18.722 116.259,18.722 116.259,18.722 112.938,18.722 112.938,18.722 112.938,18.722 112.951,28.531 112.951,28.531 112.951,28.531 108.117,28.531 108.117,28.531 108.117,28.531 108.117,18.722 108.117,18.722 108.117,18.722 103.772,18.724 103.772,18.724 101.783,18.724 100.881,20.246 100.881,21.892 100.88,23.737 102.432,25.076 104.267,25.165 105.3,25.215 105.992,24.977 106.775,24.302 106.775,24.302 106.775,27.922 106.775,27.922 105.569,28.586 104.736,28.804 103.359,28.816 99.443,28.85 96.071,25.825 96.084,21.892 96.096,18.063 98.302,15.173 103.37,15.172 107.595,15.172 116.259,15.171 116.259,15.171z M86.401,15.171C86.401,15.171 91.573,15.171 91.573,15.171 91.573,15.171 97.031,28.531 97.031,28.531 97.031,28.531 92.091,28.531 92.091,28.531 92.091,28.531 91.14,26.115 91.14,26.115 91.14,26.115 86.832,26.115 86.832,26.115 86.832,26.115 85.884,28.532 85.884,28.532 85.884,28.532 80.883,28.531 80.883,28.531 80.883,28.531 86.401,15.171 86.401,15.171z M66.358,15.171C66.358,15.171 71.289,15.173 71.289,15.173 71.289,15.173 71.289,28.531 71.289,28.531 71.289,28.531 67.237,28.531 67.237,28.531 67.237,28.531 61.603,22.875 61.603,22.875 61.603,22.875 61.605,28.531 61.605,28.531 61.605,28.531 56.751,28.531 56.751,28.531 56.751,28.531 56.751,15.173 56.751,15.173 56.751,15.173 60.585,15.173 60.585,15.173 60.585,15.173 66.356,20.929 66.356,20.929 66.356,20.929 66.358,15.171 66.358,15.171z M48.228,14.904C52.672,14.895 55.501,17.964 55.482,21.892 55.463,25.802 52.672,28.81 48.227,28.813 43.916,28.816 41.093,25.773 41.075,21.892 41.057,17.992 43.916,14.912 48.228,14.904z M36.159,14.887C37.72,14.889 38.852,14.996 40.105,15.571 40.101,15.523 40.105,19.537 40.105,19.537 39.37,18.955 38.422,18.608 37.323,18.611 35.507,18.616 34.059,20.075 34.061,21.892 34.064,23.656 35.52,25.067 37.284,25.068 38.522,25.069 39.429,24.658 40.19,24.173 40.19,24.173 40.19,28.053 40.19,28.053 38.889,28.675 38.154,28.816 36.569,28.816 32.088,28.816 29.044,25.885 29.028,21.892 29.011,17.993 32.352,14.882 36.159,14.887z M13.712,10.414C12.646,10.414 11.781,11.278 11.781,12.344 11.781,13.41 12.646,14.275 13.712,14.275 14.778,14.275 15.642,13.41 15.642,12.344 15.642,11.278 14.778,10.414 13.712,10.414z M64.909,4.045C63.485,4.051 62.632,5.49 62.65,6.913 62.667,8.316 63.51,9.706 64.912,9.71 66.32,9.715 67.174,8.32 67.191,6.913 67.208,5.484 66.338,4.038 64.909,4.045z M4.69,3.4C3.884,3.4 3.223,4.063 3.22,4.869 3.22,4.869 3.213,23.884 3.213,23.884 3.211,24.691 3.983,25.377 4.789,25.377 4.789,25.377 11.186,25.377 11.186,25.377 11.992,25.377 12.659,24.717 12.662,23.91 12.662,23.91 12.66,17.629 12.66,17.629 12.66,16.342 11.65,15.769 11.65,15.769 10.702,15.088 9.683,13.877 9.696,12.337 9.708,11.051 10.155,10.221 11.107,9.355 11.801,8.723 12.666,8.529 12.666,7.538 12.666,7.538 12.66,4.952 12.66,4.952 12.66,4.13 12.66,3.394 11.206,3.4 11.206,3.4 4.69,3.4 4.69,3.4z M16.192,3.383C14.739,3.383 14.739,4.12 14.739,4.942 14.739,4.942 14.739,7.53 14.739,7.53 14.739,8.491 15.648,8.734 16.307,9.355 17.164,10.163 17.696,11.055 17.703,12.34 17.712,13.88 16.757,15.116 15.747,15.769 15.747,15.769 14.73,16.307 14.73,17.619 14.73,17.619 14.745,20.06 14.745,20.06 14.745,20.06 14.658,21.247 16.17,21.247 21.234,21.247 24.919,16.748 24.919,12.247 24.919,7.794 20.972,3.383 16.192,3.383z M35.422,3.372C35.422,3.372 34.659,3.373 34.659,3.373 34.659,3.373 34.658,6.439 34.658,6.439 34.658,6.439 35.422,6.439 35.422,6.439 36.458,6.439 37.152,5.793 37.143,4.89 37.134,3.995 36.458,3.372 35.422,3.372z M100.624,0.178C100.624,0.178 106.149,0.178 106.149,0.178 106.149,0.178 107.453,1.968 108.105,2.864L108.452,3.34 108.437,3.361C108.437,3.361,108.467,3.361,108.467,3.361L108.452,3.34 108.803,2.864C109.461,1.968 110.777,0.178 110.777,0.178 110.777,0.178 116.285,0.178 116.285,0.178 116.285,0.178 111.296,6.688 111.296,6.688 113.029,8.991 116.312,13.52 116.312,13.52 116.312,13.52 110.709,13.52 110.709,13.52 110.709,13.52 109.431,11.501 108.792,10.491L108.452,9.954 108.467,9.93C108.467,9.93,108.437,9.93,108.437,9.93L108.452,9.954 108.112,10.491C107.473,11.501 106.195,13.52 106.195,13.52 106.195,13.52 100.591,13.52 100.591,13.52 100.591,13.52 103.874,8.991 105.607,6.688 105.607,6.688 100.624,0.178 100.624,0.178z M95.012,0.178C95.155,0.178 95.358,0.178 95.601,0.178 97.064,0.178 99.988,0.178 99.988,0.178 99.988,0.178 99.988,13.52 99.988,13.52 99.988,13.52 94.789,13.52 94.789,13.52 94.789,13.52 94.789,0.178 94.789,0.178 94.789,0.178 94.87,0.178 95.012,0.178z M64.922,0.177C64.922,0.177 77.063,0.177 77.063,0.177 77.063,0.177 77.063,3.383 77.063,3.383 77.063,3.383 71.605,3.383 71.605,3.383 71.605,3.383 71.605,5.232 71.605,5.232 71.605,5.232 76.998,5.23 76.998,5.23 76.998,5.23 76.998,8.405 76.998,8.405 76.998,8.405 71.605,8.406 71.605,8.406 71.605,8.406 71.605,10.27 71.605,10.27 71.605,10.27 77.063,10.27 77.063,10.27 77.063,10.27 77.068,13.519 77.068,13.519 77.068,13.519 64.925,13.52 64.925,13.52 62.53,13.52 60.912,12.678 59.786,11.605 58.786,10.656 57.915,8.838 57.915,6.894 57.915,4.825 58.442,3.189 59.786,1.919 61.156,0.623 62.549,0.177 64.922,0.177z M29.786,0.177C29.786,0.177 36.458,0.177 36.458,0.177 40.082,0.177 41.975,2.056 41.995,4.892 42.013,7.744 39.216,9.671 36.458,9.671 36.458,9.671 34.657,9.671 34.657,9.671 34.657,9.671 34.656,13.52 34.656,13.52 34.656,13.52 29.8,13.52 29.8,13.52 29.8,13.52 29.786,0.177 29.786,0.177z M1.986,0.177C1.986,0.177 26.109,0.177 26.109,0.177 27.205,0.177 28.094,1.065 28.094,2.162 28.094,2.162 28.094,26.548 28.094,26.548 28.094,27.645 27.205,28.534 26.109,28.534 26.109,28.534 1.986,28.534 1.986,28.534 0.889,28.534 0,27.645 0,26.548 0,26.548 0,2.162 0,2.162 0,1.065 0.889,0.177 1.986,0.177z M78.507,0.177C78.507,0.177 82.349,0.177 82.349,0.177 82.349,0.177 88.313,5.833 88.313,5.833 88.313,5.833 88.313,0.177 88.313,0.177 88.313,0.177 93.148,0.177 93.148,0.177 93.148,0.177 93.148,13.52 93.148,13.52 93.148,13.52 89.077,13.52 89.077,13.52 89.077,13.52 83.342,7.881 83.342,7.881 83.342,7.881 83.342,13.52 83.342,13.52 83.342,13.52 78.5,13.52 78.5,13.52 78.5,13.52 78.507,0.177 78.507,0.177z M42.751,0.176C42.751,0.176 42.827,0.176 42.959,0.176 43.091,0.176 43.28,0.176 43.506,0.176 44.865,0.176 47.584,0.176 47.584,0.176 47.584,0.176 47.583,4.732 47.583,4.732 47.583,4.732 51.743,4.733 51.743,4.733 51.743,4.733 51.743,0.176 51.743,0.176 51.743,0.176 56.57,0.176 56.57,0.176 56.57,0.176 56.57,13.519 56.57,13.519 56.57,13.519 51.743,13.519 51.743,13.519 51.743,13.519 51.743,8.656 51.743,8.656 51.743,8.656 47.584,8.656 47.584,8.656 47.584,8.656 47.584,13.519 47.584,13.519 47.584,13.519 42.751,13.52 42.751,13.52 42.751,13.52 42.751,0.176 42.751,0.176z");
            CommonGeometries.Add(CommonShapeType.QuestionMark, "F1M11.372,39.304C11.372,39.304 22.732,39.304 22.732,39.304 22.732,39.304 22.732,46.964 22.732,46.964 22.732,46.964 11.372,46.964 11.372,46.964 11.372,46.964 11.372,39.304 11.372,39.304z M17.998,0.112C27.654,0.112 35.227,3.687 35.227,10.516 35.227,15.814 31.914,19.197 28.506,21.942 25.193,24.751 21.785,26.921 21.785,30.049 21.785,30.049 21.785,34.644 21.785,34.644 21.785,34.644 12.034,34.644 12.034,34.644 12.034,34.644 12.034,28.07 12.034,28.07 12.034,25.261 14.59,22.453 17.146,19.644 19.607,16.836 22.164,14.027 22.164,11.219 22.164,8.665 21.122,6.623 16.673,6.623 11.561,6.623 11.561,10.261 11.561,13.197 11.561,13.197 0.201,13.197 0.201,13.197 0.201,8.665 -0.083,0.112 17.998,0.112z");
            CommonGeometries.Add(CommonShapeType.SpeakBubble, "F1M40.71,0.183C15.667,0.183 0.404,14.806 0.404,32.845 0.404,50.885 15.667,65.312 40.71,65.312 43.761,65.312 46.742,64.429 49.625,64.015 61.284,78.753 79.67,75.854 79.67,75.854 66.683,69.707 66.946,59.526 69.255,58.17 79.449,52.181 85.578,43.061 85.578,32.845 85.578,14.806 65.753,0.183 40.71,0.183z");
            CommonGeometries.Add(CommonShapeType.Ok, "");
            CommonGeometries.Add(CommonShapeType.ArrowUpInCycle, "F1M11.812,7.547C11.812,7.547 16.5,12.703 16.5,12.703 16.5,12.703 7.125,12.703 7.125,12.703 7.125,12.703 11.812,7.547 11.812,7.547z M11.918,2.204C9.349,2.205 7.03,3.243 5.345,4.927 3.662,6.612 2.623,8.93 2.623,11.499 2.623,14.069 3.662,16.387 5.345,18.072 7.03,19.756 9.349,20.795 11.918,20.795 14.488,20.795 16.806,19.756 18.491,18.072 20.175,16.387 21.213,14.069 21.214,11.499 21.213,8.93 20.175,6.612 18.491,4.927 16.806,3.243 14.488,2.205 11.918,2.204z M11.918,0.428C18.033,0.429 22.989,5.384 22.99,11.499 22.989,17.615 18.033,22.571 11.918,22.572 5.803,22.571 0.847,17.615 0.846,11.499 0.847,5.384 5.803,0.429 11.918,0.428z");
            CommonGeometries.Add(CommonShapeType.ArrowDownInCycle, "F1M7.344,10.297C7.344,10.297 16.719,10.297 16.719,10.297 16.719,10.297 12.031,15.453 12.031,15.453 12.031,15.453 7.344,10.297 7.344,10.297z M11.925,2.205C9.356,2.205 7.037,3.244 5.353,4.928 3.669,6.613 2.63,8.931 2.63,11.501 2.63,14.07 3.669,16.388 5.353,18.073 7.037,19.757 9.356,20.795 11.925,20.796 14.495,20.795 16.814,19.757 18.499,18.073 20.182,16.388 21.221,14.07 21.221,11.501 21.221,8.931 20.182,6.613 18.499,4.928 16.814,3.244 14.495,2.205 11.925,2.205z M11.925,0.428C18.041,0.429 22.997,5.385 22.997,11.501 22.997,17.616 18.041,22.571 11.925,22.572 5.81,22.571 0.854,17.616 0.854,11.501 0.854,5.385 5.81,0.429 11.925,0.428z");
            CommonGeometries.Add(CommonShapeType.Plus, "F1M0.989,7.796C0.989,7.796 5.217,7.796 5.217,7.796 5.217,7.796 5.217,12.008 5.217,12.008 5.217,12.008 8.782,12.008 8.782,12.008 8.782,12.008 8.782,7.796 8.782,7.796 8.782,7.796 13.032,7.796 13.032,7.796 13.032,7.796 13.032,4.244 13.032,4.244 13.032,4.244 8.782,4.244 8.782,4.244 8.782,4.244 8.782,0.01 8.782,0.01 8.782,0.01 5.217,0.01 5.217,0.01 5.217,0.01 5.217,4.244 5.217,4.244 5.217,4.244 0.989,4.244 0.989,4.244 0.989,4.244 0.989,7.796 0.989,7.796z");
            CommonGeometries.Add(CommonShapeType.Minus, "F1M0.989,3.796C0.989,3.796 13.032,3.796 13.032,3.796 13.032,3.796 13.032,0.244 13.032,0.244 13.032,0.244 0.989,0.244 0.989,0.244 0.989,0.244 0.989,3.796 0.989,3.796z");
            CommonGeometries.Add(CommonShapeType.ArrowDown, "F1M4,4L0,0 8,0z");
            CommonGeometries.Add(CommonShapeType.ArrowUp, "F1M8,4L0,4 4,0z");
            CommonGeometries.Add(CommonShapeType.Printer, "");
            CommonGeometries.Add(CommonShapeType.Undo, "");
            CommonGeometries.Add(CommonShapeType.Redo, "");
            CommonGeometries.Add(CommonShapeType.Symbol, "");
            CommonGeometries.Add(CommonShapeType.Cloud, "");
            CommonGeometries.Add(CommonShapeType.Copy, "");
            CommonGeometries.Add(CommonShapeType.Refresh, "");
            CommonGeometries.Add(CommonShapeType.User, "");
            CommonGeometries.Add(CommonShapeType.Key, "");
            CommonGeometries.Add(CommonShapeType.Service, "F1M11.284,38.586C11.281,38.59,11.277,38.594,11.274,38.598L11.277,38.593z M6.499,32.428C6.499,32.428 4.71,34.221 4.71,34.221 4.71,34.221 5.368,36.667 5.368,36.667 5.368,36.667 7.815,37.32 7.815,37.32 7.815,37.32 9.604,35.527 9.604,35.527 9.604,35.527 8.947,33.081 8.947,33.081 8.947,33.081 6.499,32.428 6.499,32.428z M15.787,21.791C15.944,22.007 16.082,22.226 16.191,22.447 16.269,22.606 16.327,22.756 16.36,22.893 16.385,22.93 16.359,23.186 16.488,23.618 16.601,23.963 16.84,24.264 17.126,24.445 17.413,24.629 17.731,24.705 18.032,24.705 18.3,24.704 18.558,24.647 18.799,24.539 19.377,24.277 19.838,23.924 20.241,23.621 20.385,23.512 20.527,23.402 20.666,23.289 20.666,23.289 21.909,24.533 21.909,24.533 21.909,24.533 12.998,33.46 12.998,33.46 13.025,33.604 13.046,33.749 13.062,33.895 13.155,34.767 13.032,35.647 12.724,36.458L11.277,38.593 11.086,38.796C10.634,39.249 10.102,39.622 9.523,39.895 7.89,40.664 5.945,40.58 4.381,39.68 2.854,38.803 1.821,37.199 1.636,35.449 1.452,33.706 2.137,31.928 3.437,30.754 3.433,30.757 3.43,30.76 3.426,30.764 3.506,30.675 3.589,30.589 3.675,30.505 4.951,29.264 6.811,28.706 8.56,29.031 8.56,29.031 15.787,21.791 15.787,21.791z M32.335,1.17C33.283,1.015 34.26,1.04 35.2,1.257 35.2,1.257 31.628,4.835 31.628,4.835 31.628,4.835 32.798,9.187 32.798,9.187 32.798,9.187 37.152,10.35 37.152,10.35 37.211,10.291 37.269,10.232 37.328,10.174 37.984,9.517 38.64,8.86 39.296,8.203 39.772,7.726 40.248,7.249 40.724,6.771 41.117,8.463 40.896,10.265 40.104,11.81 39.904,12.201 39.668,12.575 39.402,12.924 39.269,13.1 39.127,13.269 38.979,13.432 38.829,13.596 38.664,13.743 38.512,13.905 37.888,14.566 37.144,15.113 36.324,15.506 34.56,16.353 32.475,16.455 30.634,15.793 30.634,15.793 24.443,21.995 24.443,21.995 24.443,21.995 23.203,20.755 23.203,20.755 23.395,20.517 23.582,20.273 23.762,20.022 24.002,19.684 24.316,19.273 24.521,18.724 24.594,18.527 24.628,18.325 24.628,18.121 24.629,17.681 24.461,17.188 24.031,16.844 23.703,16.586 23.362,16.522 23.142,16.488 22.915,16.457 22.772,16.442 22.739,16.429 22.402,16.333 22.047,16.129 21.696,15.872 21.696,15.872 26.196,11.363 26.196,11.363 25.604,9.723 25.613,7.889 26.227,6.257 26.538,5.432 26.996,4.663 27.575,3.998 27.721,3.831 27.873,3.671 28.033,3.518 28.202,3.356 28.358,3.184 28.53,3.025 28.875,2.706 29.251,2.42 29.651,2.171 30.471,1.662 31.388,1.325 32.335,1.17z M4.982,0.16C5.363,0.167 5.733,0.308 6.069,0.644 6.069,0.644 17.295,11.877 17.295,11.877 17.534,12.117 17.716,12.401 17.828,12.721 17.914,12.966 17.993,13.21 18.102,13.447 18.339,13.964 18.64,14.451 18.974,14.911 19.434,15.545 19.959,16.137 20.55,16.652 21.028,17.068 21.575,17.475 22.191,17.656 22.477,17.739 22.815,17.692 23.058,17.884 23.289,18.067 23.344,18.402 23.246,18.669 23.12,19.012 22.893,19.324 22.681,19.618 22.403,20.005 22.103,20.376 21.789,20.735 21.789,20.735 34.839,33.793 34.839,33.793 35.347,34.301 35.844,34.671 36.475,35.014 36.475,35.014 37.244,35.431 37.244,35.431 37.534,35.588 37.755,35.772 37.962,36.029 37.962,36.029 40.033,38.605 40.033,38.605 40.033,38.605 39.723,38.914 39.723,38.914 39.723,38.914 38.577,40.06 38.577,40.06 38.577,40.06 38.507,40.13 38.507,40.13 38.507,40.13 35.932,38.057 35.932,38.057 35.676,37.851 35.491,37.63 35.334,37.34 35.334,37.34 34.918,36.571 34.918,36.571 34.575,35.939 34.205,35.442 33.698,34.933 33.698,34.933 20.648,21.876 20.648,21.876 20.367,22.12 20.079,22.356 19.782,22.581 19.436,22.843 19.075,23.112 18.677,23.291 18.3,23.461 17.83,23.362 17.687,22.937 17.626,22.754 17.639,22.556 17.594,22.369 17.548,22.182 17.476,22.002 17.391,21.829 17.185,21.409 16.903,21.027 16.599,20.673 15.919,19.881 15.099,19.193 14.213,18.644 13.82,18.401 13.409,18.183 12.975,18.023 12.765,17.945 12.549,17.889 12.349,17.786 12.143,17.68 11.957,17.539 11.793,17.375 11.793,17.375 0.567,6.142 0.567,6.142 -0.656,4.919 0.748,3.236 1.629,2.296 1.629,2.296 1.629,2.295 1.629,2.295 1.711,2.209 1.793,2.124 1.877,2.04 2.595,1.317 3.838,0.137 4.982,0.16z");
            CommonGeometries.Add(CommonShapeType.Cells, "F1M40.695,24.776C40.695,24.776 49.296,33.799 49.296,33.799 49.296,33.799 45.783,45.759 45.783,45.759 45.783,45.759 33.668,48.696 33.668,48.696 33.668,48.696 25.067,39.673 25.067,39.673 25.067,39.673 28.581,27.713 28.581,27.713 28.581,27.713 40.695,24.776 40.695,24.776z M16.62,17.531C16.62,17.531 25.221,26.554 25.221,26.554 25.221,26.554 21.708,38.514 21.708,38.514 21.708,38.514 9.593,41.452 9.593,41.452 9.593,41.452 0.992,32.429 0.992,32.429 0.992,32.429 4.506,20.469 4.506,20.469 4.506,20.469 16.62,17.531 16.62,17.531z M34.703,0.064C34.703,0.064 43.304,9.086 43.304,9.086 43.304,9.086 39.791,21.047 39.791,21.047 39.791,21.047 27.676,23.984 27.676,23.984 27.676,23.984 19.075,14.961 19.075,14.961 19.075,14.961 22.589,3.001 22.589,3.001 22.589,3.001 34.703,0.064 34.703,0.064z");
            CommonGeometries.Add(CommonShapeType.Gear, "m 9.078924,14.016705 c 1.076996,0 1.948996,0.873 1.948996,1.95 0,1.076 -0.872,1.949 -1.948996,1.949 -1.076,0 -1.949,-0.873 -1.949,-1.949 0,-1.077 0.873,-1.95 1.949,-1.95 z m 0.6499985,-2.167 c -2.2569985,-0.399 -4.4109985,1.11 -4.8089985,3.369 -0.398,2.26 1.11,4.415 3.368,4.813 2.257996,0.399 4.410996,-1.11 4.808996,-3.37 0.398,-2.259 -1.11,-4.414 -3.3679975,-4.812 z M 8.625924,7.3587135 l 0.34,1.9309975 c 0.395,-0.002 0.794998,0.024 1.197996,0.095 0.254,0.045 0.5,0.1089995 0.743,0.1809985 l 0.836,-1.7959955 1.931,0.901 -0.849,1.821992 c 0.53,0.373 0.991,0.828 1.388,1.331 l 1.779,-1.028 1.065,1.846 -1.8,1.04 c 0.275,0.76 0.415,1.578 0.393,2.42 l 2.083,0.368 -0.37,2.098 -2.104,-0.371 c -0.214,0.595 -0.51,1.144 -0.869,1.64 l 1.522,1.523 -1.506,1.507 -1.523,-1.524 c -0.502,0.362 -1.055,0.65 -1.641,0.861 l 0.373,2.117 -2.096996,0.37 -0.37,-2.099 c -0.426,0.009 -0.859,-0.02 -1.294,-0.097 -0.192,-0.034 -0.379,-0.077 -0.564,-0.126 l -0.89,1.911 -1.931,-0.901 0.88,-1.888 c -0.534,-0.353 -1.002,-0.787 -1.41,-1.271 l -1.788,1.034 -1.065,-1.846 1.75,-1.011 c -0.308,-0.773 -0.476,-1.61 -0.473,-2.475 l -1.95000024,-0.344 0.37000012,-2.099 1.92900012,0.34 c 0.214,-0.638 0.523,-1.223 0.901,-1.751 l -1.378,-1.379 1.506,-1.506994 1.37,1.369994 c 0.534,-0.388 1.126,-0.6949985 1.755,-0.910997 l -0.337,-1.911995 z M 18.681047,4.6964526 c 0.697,-0.148 1.383,0.2969997 1.531,0.9949967 0.148,0.698 -0.298,1.383 -0.995,1.531 -0.698,0.148 -1.384,-0.297 -1.532,-0.995 -0.148,-0.698 0.298,-1.3829967 0.996,-1.5309967 z m 0.123,-1.495 c -1.518,0.052 -2.706,1.326 -2.654,2.8459967 0.053,1.519 1.326,2.708 2.844,2.656 1.519,-0.052 2.707,-1.326 2.654,-2.845 -0.052,-1.5199967 -1.326,-2.7089967 -2.844,-2.6569967 z m 0.745,-2.92100042 1.375,0.31900015 -0.3,1.29700027 c 0.395,0.17 0.756,0.401 1.082,0.672 l 1.012,-0.91 0.944,1.05 -1.023,0.921 c 0.282,0.455 0.485,0.966 0.587,1.5149987 l 1.401,-0.049 0.048,1.411998 -1.414,0.048 c -0.057,0.415 -0.174,0.812 -0.338,1.183 l 1.195,0.778 -0.769,1.1839945 -1.196,-0.7789945 c -0.276,0.3029985 -0.595,0.565996 -0.945,0.7829945 l 0.532,1.3209972 -1.308,0.528 -0.528,-1.309 c -0.275,0.064 -0.559,0.105 -0.852,0.115 -0.129,0.004 -0.257,0.002 -0.383,-0.004 l -0.314,1.361 -1.375,-0.319 0.311,-1.344 c -0.395,-0.1559987 -0.759,-0.3729972 -1.089,-0.6299952 l -1.017,0.9149952 -0.944,-1.0499942 0.995,-0.8959975 c -0.306,-0.459 -0.53,-0.978 -0.646,-1.539 l -1.312,0.045 -0.049,-1.411 1.297,-0.045 c 0.051,-0.441997 0.171,-0.8639968 0.344,-1.2589968 l -1.083,-0.704 0.769,-1.184 1.076,0.7 c 0.293,-0.325 0.634,-0.605 1.012,-0.832 l -0.481,-1.19200009 1.309,-0.52900024 0.486,1.20500033 c 0.255,-0.056 0.518,-0.093 0.789,-0.103 0.171,-0.006 0.339,0.002 0.506,0.015 z");
            CommonGeometries.Add(CommonShapeType.Process, "F1M48.611,27.742C48.611,27.742 42.804,27.742 42.804,27.742 42.804,27.742 42.804,16.822 42.804,16.822 42.804,16.822 25.861,16.822 25.861,16.822 25.861,16.822 25.861,8.258 25.861,8.258 25.861,8.258 31.668,8.258 31.668,8.258 32.027,8.258 32.318,7.967 32.318,7.608 32.318,7.608 32.318,0.778 32.318,0.778 32.318,0.418 32.027,0.127 31.668,0.127 31.668,0.127 18.332,0.127 18.332,0.127 17.973,0.127 17.682,0.418 17.682,0.778 17.682,0.778 17.682,7.608 17.682,7.608 17.682,7.967 17.973,8.258 18.332,8.258 18.332,8.258 24.139,8.258 24.139,8.258 24.139,8.258 24.139,16.822 24.139,16.822 24.139,16.822 7.196,16.822 7.196,16.822 7.196,16.822 7.196,27.742 7.196,27.742 7.196,27.742 1.389,27.742 1.389,27.742 1.029,27.742 0.738,28.033 0.738,28.392 0.738,28.392 0.738,35.222 0.738,35.222 0.738,35.582 1.029,35.873 1.389,35.873 1.389,35.873 14.724,35.873 14.724,35.873 15.083,35.873 15.375,35.582 15.375,35.222 15.375,35.222 15.375,28.392 15.375,28.392 15.375,28.033 15.083,27.742 14.724,27.742 14.724,27.742 8.917,27.742 8.917,27.742 8.917,27.742 8.917,18.543 8.917,18.543 8.917,18.543 24.139,18.543 24.139,18.543 24.139,18.543 24.139,27.742 24.139,27.742 24.139,27.742 18.332,27.742 18.332,27.742 17.973,27.742 17.682,28.033 17.682,28.392 17.682,28.392 17.682,35.222 17.682,35.222 17.682,35.582 17.973,35.873 18.332,35.873 18.332,35.873 31.668,35.873 31.668,35.873 32.027,35.873 32.318,35.582 32.318,35.222 32.318,35.222 32.318,28.392 32.318,28.392 32.318,28.033 32.027,27.742 31.668,27.742 31.668,27.742 25.861,27.742 25.861,27.742 25.861,27.742 25.861,18.543 25.861,18.543 25.861,18.543 41.083,18.543 41.083,18.543 41.083,18.543 41.083,27.742 41.083,27.742 41.083,27.742 35.276,27.742 35.276,27.742 34.917,27.742 34.625,28.033 34.625,28.392 34.625,28.392 34.625,35.222 34.625,35.222 34.625,35.582 34.917,35.873 35.276,35.873 35.276,35.873 48.611,35.873 48.611,35.873 48.971,35.873 49.262,35.582 49.262,35.222 49.262,35.222 49.262,28.392 49.262,28.392 49.262,28.033 48.971,27.742 48.611,27.742z");

            CommonGeometries.Add(CommonShapeType.Open, "");
            CommonGeometries.Add(CommonShapeType.Save, "");
            CommonGeometries.Add(CommonShapeType.Paste, "");
            CommonGeometries.Add(CommonShapeType.Cut, "");
            CommonGeometries.Add(CommonShapeType.Properties, "");
            CommonGeometries.Add(CommonShapeType.New, "");
            CommonGeometries.Add(CommonShapeType.Delete, "F1 M 8.1285946,6.3675556 10.111078,4.7349232 10.111078,4.2684568 8.9449115,4.2684568 8.9449115,3.8019904 A 3.3818814,3.3818814 0 0 0 2.9041719,2.029418 L 4.1636306,3.1256141 A 1.7492491,1.7492491 0 0 1 7.3122786,3.8019904 L 7.3122786,4.2684568 6.1461126,4.2684568 6.1461126,4.7349232 z M 16,7 15,19 5,19 4,7 z M 9,9 9,17 A 1,1 180 1 0 11,17 L 11,9 A 1,1 180 1 0 9,9 z M 5,9 6,17 A 1,1 180 1 0 8,17 L 7,9 A 1,1 180 1 0 5,9 z M 13,9 12,17 A 1,1 180 1 0 14,17 L 15,9 A 1,1 180 1 0 13,9 z M 9.3046335,1.064463 18.509396,8.7633181 19.150966,7.9962546 15.699181,5.109184 16.340752,4.3421206 14.039562,2.4174068 13.39799,3.1844702 9.9462047,0.29739951 z");

            CommonGeometries.Add(CommonShapeType.Camera, "");

            CommonGeometries.Add(CommonShapeType.ArrowRight2, "F1M0.636,0.515C0.636,0.515 9.981,0.515 9.981,0.515 9.981,0.515 16.656,10.528 16.656,10.528 16.656,10.528 9.981,20.542 9.981,20.542 9.981,20.542 0.636,20.542 0.636,20.542 0.636,20.542 7.312,10.528 7.312,10.528 7.312,10.528 0.636,0.515 0.636,0.515z");

            CommonGeometries.Add(CommonShapeType.Home, "M 1.875,13.125 6.562,13.125 6.562,9.375 8.438,9.375 8.438,13.125 13.125,13.125 13.125,7.5 15,7.5 7.5,0 0,7.5 1.875,7.5");
            CommonGeometries.Add(CommonShapeType.BarChart, "F1 M0,0 0,30 50,30 50,27 3,27 3,0z M4,2 14,2 14,5 4,5z M10,7 20,7 20,10 10,10z M18,12 25,12 25,15 18,15z M24,17 34,17 34,20 24,20z M34,22 44,22 44,25 34,25z");
            CommonGeometries.Add(CommonShapeType.Heartrate, "");
            CommonGeometries.Add(CommonShapeType.Binocular, "F1M 4.6870068,-0.00214795 7.9988407,-0.00214795 7.9988407,2.9070629 4.6870068,2.9070629 z M 2.2031315,3.3226643 8.4128199,3.3226643 8.4128199,5.8162732 7.5848615,5.8162732 7.5848615,9.1410858 8.4128199,9.1410858 8.4128199,11.634695 0.54721447,11.634695 z M 11.724653,3.3226643 17.934341,3.3226643 19.590258,11.634695 11.724653,11.634695 11.724653,9.1410858 12.552611,9.1410858 12.552611,5.8162732 11.724653,5.8162732 z M 1.375173,12.050297 6.3429238,12.050297 7.1708822,18.284319 7.1708822,19.946725 0.54721447,19.946725 0.54721447,18.284319 z M 12.138632,-0.00214795 15.450467,-0.00214795 15.450467,2.9070629 12.138632,2.9070629 z M 13.79455,12.050297 18.7623,12.050297 19.590258,18.284319 19.590258,19.946725 12.966591,19.946725 12.966591,18.284319 z M 7.9988407,6.2318747 12.138632,6.2318747 11.724653,8.7254841 8.4128199,8.7254841 z M 9.2407783,3.7382657 10.896695,3.7382657 10.896695,5.4006719 9.2407783,5.4006719 z M 9.2407783,9.5566871 10.896695,9.5566871 10.896695,11.219093 9.2407783,11.219093 z");
            CommonGeometries.Add(CommonShapeType.BinocularCrossed, "F1M 4.687,0 7.999,0 7.999,2.907 4.687,2.907 z M 12.139,0 15.45,0 15.45,2.907 12.139,2.907 z M 9.241,3.738 10.897,3.738 10.897,5.401 9.241,5.401 z M 8.088,6.775 10.098,8.719 12.043,6.797 12.139,6.232 7.999,6.232 z M 12.924628,11.625 12.383628,11.095 17.222626,6.234 A 1.5453839,1.5453839 0 0 0 15.040628,4.045 L 12.661628,6.421 12.661628,5.816 11.828628,5.816 11.828628,3.323 18.038626,3.323 19.694626,11.625 z M 7.317,11.625 7.858,11.095 3.019,6.234 A 1.5453839,1.5453839 180 0 1 5.201,4.045 L 7.58,6.421 7.58,5.816 8.413,5.816 8.413,3.323 2.203,3.323 0.547,11.625 z M 3.3458397,5.8679686 8.615658,11.137783 3.3458397,16.407601 A 1.0646643,1.0646643 0 0 0 4.851502,17.913264 L 10.121321,12.643446 15.391139,17.913264 A 1.0646645,1.0646645 0 1 0 16.896802,16.407601 L 11.626984,11.137783 16.896802,5.8679686 A 1.0646643,1.0646643 0 0 0 15.391139,4.3623063 L 10.121321,9.6321246 4.851502,4.3623063 A 1.0646641,1.0646641 0 0 0 3.3458397,5.8679686 z M 6.937,16.617 5.25,18.344 A 1.6139716,1.6139716 180 0 1 2.969,16.06 L 6.406,12.719 6.343,12.05 1.375,12.05 0.547,18.284 0.547,20 7.171,20 7.171,18.284 z M 13.319752,16.592001 15.006752,18.319001 A 1.6139716,1.6139716 0 1 0 17.287752,16.035001 L 13.850752,12.694001 13.913752,12.025001 18.881752,12.025001 19.709752,18.259001 19.709752,19.975001 13.085752,19.975001 13.085752,18.259001 z");
            CommonGeometries.Add(CommonShapeType.ClockWithCheckmark, "F1 M 8,3 8,8 7,8 7,10 8,10 8,11 10,11 10,10 15,10 15,8 10,8 10,3 z M 3.977,16.383 A 9,9 0 1 1 17.454,6.017 1,1 0 0 1 15.595,6.749 7,7 0 1 0 5.083,14.78 1,1 0 0 1 3.977,16.383 z M 5.8814285,14.840038 10.84068,19.683057 A 0.77488311,0.77488311 0 0 0 11.809284,19.644313 L 19.829324,10.268228 A 1.743487,1.743487 0 0 0 17.504675,7.86609 L 11.073145,15.304968 8.4617892,12.406905 A 1.7733019,1.7733019 0 0 0 5.8814285,14.840038 z");
            CommonGeometries.Add(CommonShapeType.Document, "");
            CommonGeometries.Add(CommonShapeType.SignedDocument, "");
            CommonGeometries.Add(CommonShapeType.Pause, "");
            CommonGeometries.Add(CommonShapeType.Eye, "");
        }

        /// <summary>
        /// Creates the icon by given <see cref="CommonShapeType"/>
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public static Geometry GetShapeGeometry(CommonShapeType shapeType)
        {
            return !CommonGeometries.ContainsKey(shapeType) ? null : Geometry.Parse(CommonGeometries[shapeType]);
        }
    }
}