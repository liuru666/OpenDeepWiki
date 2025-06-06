import React from 'react';
import { Repository } from '../types';
import Link from 'next/link';
import {
  FileOutlined,
  ClockCircleOutlined,
  CodeOutlined,
  GithubOutlined,
  RobotOutlined,
} from '@ant-design/icons';
import { ChevronsRight, Heart, Sparkles, Star } from 'lucide-react';
import { Badge } from 'antd';
import { MaskShadow } from '@lobehub/ui';
import { useTranslation } from '../i18n/client';

interface RepositoryCardProps {
  repository: Repository;
}

const RepositoryCard: React.FC<RepositoryCardProps> = ({ repository }) => {
  const { t, i18n } = useTranslation();
  const currentLocale = i18n.language;

  // 获取仓库所有者和名称
  const getRepoInfo = (address: string) => {
    try {
      if (address.includes('github.com')) {
        const parts = address.replace('https://github.com/', '').split('/');
        return {
          owner: parts[0],
          name: parts[1].split('/')[0].replace('.git', '')
        }
      }

      // 解析 url
      const url = new URL(address);
      const owner = url.pathname.split('/')[1];
      const name = url.pathname.split('/')[2];
      return {
        owner: owner,
        name: name.split('.')[0]
      }

    } catch (e) {
      // 如果解析失败，返回默认值
    }
    return { owner: repository.organizationName, name: repository.name };
  };


  // 根据地址获取头像
  const getAvatarUrl = () => {
    if (repository.address.includes('github.com')) {
      const owner = repository.organizationName;
      if (owner) {
        return `https://github.com/${owner}.png`;
      }
    }
    return null;
  };

  const avatarUrl = getAvatarUrl();

  // 获取状态小圆点
  const getStatusDot = (status: number) => {
    let statusClass = '';

    switch (status) {
      case 0: statusClass = 'status-pending'; break;
      case 1: statusClass = 'status-processing'; break;
      case 2: statusClass = 'status-completed'; break;
      case 3: statusClass = 'status-cancelled'; break;
      case 4: statusClass = 'status-unauthorized'; break;
      case 99: statusClass = 'status-failed'; break;
      default: statusClass = 'status-unknown'; break;
    }

    return <span className={`status-dot ${statusClass}`}></span>;
  };

  // 获取状态文本
  const getStatusText = (status: number) => {
    switch (status) {
      case 0: return t('repository.status.pending', '待处理');
      case 1: return t('repository.status.processing', '处理中');
      case 2: return t('repository.status.completed', '已完成');
      case 3: return t('repository.status.cancelled', '已取消');
      case 4: return t('repository.status.unauthorized', '未授权');
      case 99: return t('repository.status.failed', '已失败');
      default: return t('repository.status.unknown', '未知状态');
    }
  };

  const formatDate = (dateString: string) => {
    const date = new Date(dateString);
    const locale = currentLocale === 'zh-CN' ? 'zh-CN' : 'en-US';
    return date.toLocaleDateString(locale);
  };

  return (
    <Link href={`/${repository.organizationName}/${repository.name}`} className="repo-card-link">
      <Badge.Ribbon
        style={{
          display: repository.isRecommended ? 'block' : 'none',
        }}
        placement="start"
        text={<Heart
          size={14}
        />} color="pink">
        <div className="minimal-repo-card">
          <div className="repo-header">

            <div className="repo-avatar-wrap">
              {avatarUrl ? (
                <img
                  src={avatarUrl}
                  loading="lazy"
                  alt={repository.organizationName}
                  className="repo-avatar"
                />
              ) : (
                <span className="repo-default-icon">
                  <FileOutlined />
                </span>
              )}
            </div>

            <div className="repo-main-info">
              <div className="repo-title-row">
                <h3 className="repo-name" title={repository.name}>{repository.name}</h3>
                <div className="repo-type">
                  {repository.type === 'git' ? <GithubOutlined /> : <FileOutlined />}
                </div>
              </div>

              <div className="repo-meta">
                <span className="repo-url" title={repository.address}>
                  {repository.address.replace('https://github.com/', '').replace('.git', '').replace('https://gitlab.com/', '').replace('.git', '').replace('https://gitee.com/', '').replace('.git', '')}
                </span>
                <div className="repo-status">
                  {getStatusDot(repository.status)}
                  <span className="status-text">{getStatusText(repository.status)}</span>
                </div>
              </div>
            </div>
          </div>
          <div>
            <MaskShadow width={'100%'}
              position='bottom'
              height={68}
              size={12}
            >
              {repository.description}
            </MaskShadow>
          </div>
          <div className="repo-footer">
            <div className="repo-details">
              <span className="repo-date">
                <ClockCircleOutlined />
                {formatDate(repository.createdAt)}
              </span>
            </div>

            <div className="repo-actions">
              <span className="action-docs">
                <ChevronsRight />
              </span>
            </div>
          </div>
        </div>
      </Badge.Ribbon>
    </Link>
  );
};

export default RepositoryCard; 